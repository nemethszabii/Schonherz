import java.io.*;
import java.util.Scanner;

public class CustomFileHandler {

    static String getFileName(Scanner scanner) {
        try {
            System.out.print("Enter filename: ");
            return scanner.nextLine();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return "";
    }

    public static void writeCartToFile(Scanner scanner, ShoppingCart sc) {
        String fileName = getFileName(scanner);
        try (BufferedWriter bw = new BufferedWriter(new FileWriter(fileName))) {
            for (AbstractProduct p : sc.getProducts()) {
                bw.write(p.serializeObj() + "\n");
            }
            System.out.println("\n[SUCCESS] - Writing was successful to " + fileName + "!\n");
        } catch (ShoppingCartEmpty | IOException e) {
            System.out.println("\n" + e.getMessage() + "\n");
        }
    }

    public static void readCartFromFile(Scanner scanner, ShoppingCart sc) {
        String fileName = getFileName(scanner);
        String line;
        int count = 0;
        try (BufferedReader br = new BufferedReader(new FileReader(fileName))) {
            while ((line = br.readLine()) != null) {
                AbstractProduct p = (AbstractProduct)IProduct.deserializeObj(line);
                sc.addProduct(p);
                count++;
            }
            if (count > 0) {
                System.out.println("\n[SUCCESS] - Reading was successful!\n");
            } else {
                throw new FileEmpty();
            }
        } catch (FileEmpty | IOException e) {
            System.out.println("\n" + e.getMessage() + "\n");
        }
    }
}
