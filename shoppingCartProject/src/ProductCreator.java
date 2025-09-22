public class ProductCreator {
    public static AbstractProduct objCreator(String type, String brand, int price) throws Exception {
        if  (type.equals("Shoe")) {
            return new Shoe(brand, price);
        } else if (type.equals("GUITAR")) {
            return new Guitar(brand, price);
        } else {
            throw new Exception("[ERROR] - Unknown product type!");
        }
    }
}
