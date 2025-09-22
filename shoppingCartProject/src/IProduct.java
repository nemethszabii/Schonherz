public interface IProduct {
    int getId();
    void setId(int id);
    String serializeObj();

    String getBrand();
    int getPrice();
    void setBrand(String value);
    void setPrice(int value);

    static IProduct deserializeObj(String line) {
        String[] parts = line.split("#");
        switch (parts[0]) {
            case "Guitar":
                return new Guitar(parts[1], Integer.parseInt(parts[2]));
            case "Shoe":
                return new Shoe(parts[1], Integer.parseInt(parts[2]));
            default:
                throw new IllegalArgumentException("Unknown product type: " + parts[0]);
        }
    }
}
