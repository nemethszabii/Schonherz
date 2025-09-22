import javax.sound.sampled.*;
import java.util.*;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        ShoppingCart sc = new ShoppingCart();
        runCartProgram(sc, scanner);
        scanner.close();
    }

    static void runCartProgram(ShoppingCart sc, Scanner scanner) {
        try {
            String answer = "";
            do {
                CustomMenu.displayMenu();
                answer = scanner.nextLine();
                switch (answer) {
                    case "1":
                        try {
                            displayCart(sc.getProducts());
                        } catch (ShoppingCartEmpty e) {
                            System.out.println("\n" + e.getMessage() + "\n");
                        }
                        break;
                    case "2":
                        userInputHelperForCreation(scanner, sc);
                        break;
                    case "3":
                        userInputHelperForUpdate(scanner, sc);
                        break;
                    case "4":
                        userInputHelperForDelete(scanner, sc);
                        break;
                    case "5":
                        try {
                            CustomFileHandler.readCartFromFile(scanner, sc);
                        } catch (FileEmpty e) {
                            System.out.println("\n" + e.getMessage() + "\n");
                        }
                        break;
                    case "6":
                        CustomFileHandler.writeCartToFile(scanner, sc);
                        break;
                    case "7":
                        System.out.println("Program is ending...");
                        break;
                    default:
                        System.out.println("[ERROR] - Invalid choice");
                }
            } while (!answer.equals("7"));
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    static void displayCart(ArrayList<AbstractProduct> products) {
        System.out.println();
        for (AbstractProduct p : products) {
            System.out.println(p);
        }
        System.out.println();
    }

    static void userInputHelperForDelete(Scanner scanner, ShoppingCart sc) {
        try {
            int id = readInt(scanner, "Enter product ID: ");
            if (sc.removeProduct(id)) {
                System.out.println("\n[SUCCESS] - Product has been deleted!\n");
            } else {
                System.out.println("\n[ERROR] - There is no product with this id!\n");
            }
        } catch (Exception e) {
            System.out.println("\n[ERROR] - Invalid ID!\n");
        }
    }

    static void userInputHelperForUpdate(Scanner scanner, ShoppingCart sc) {
        int id = readInt(scanner, "Enter ID of product you want to update: ");

        AbstractProduct oldProduct;
        try {
            oldProduct = sc.getProduct(id);
        } catch (ProductDoesNotExist e) {
            System.out.println("\n[ERROR] - Product with this id does not exist!\n");
            return;
        }

        String brand = readString(scanner, "Enter new brand [old value = " + oldProduct.getBrand() + "]: ");
        int price = readInt(scanner, "Enter new price [old price = " + oldProduct.getPrice() + " HUF]: ");

        AbstractProduct updatedProduct = oldProduct.updateWithCorrectType(brand, price);
        if (sc.updateProduct(id, updatedProduct)) {
            System.out.println("\n[SUCCESS] - Product has been updated!\n");
        } else {
            System.out.println("[ERROR] - Product could not be updated!\n!");
        }
    }

    static void userInputHelperForCreation(Scanner scanner, ShoppingCart sc) {
        try {
            String type = readString(scanner, "Enter product type [Guitar|Shoe]: ");
            String brand = readString(scanner, "Enter product Brand: ");
            int price = readInt(scanner, "Enter product Price: ");

            AbstractProduct newObj = ProductCreator.objCreator(type, brand, price);

            if (sc.addProduct(newObj)) {
                System.out.println("\n[SUCCESS] - Product added!\n");
            } else {
                System.out.println("\n[ERROR] - Product could not be created!\n");
            }
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    static int readInt(Scanner scanner, String msg) {
        while (true) {
            System.out.print(msg);
            String input = scanner.nextLine();
            try {
                return Integer.parseInt(input);
            } catch (NumberFormatException e) {
                System.out.println("[ERROR] - Please enter a valid number!");
            }
        }
    }

    static String readString(Scanner scanner, String msg) {
        String input;
        do {
            System.out.print(msg);
            input = scanner.nextLine();
        } while (input.isEmpty());
        return input;
    }
}