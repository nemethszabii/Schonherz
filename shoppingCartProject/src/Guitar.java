public class Guitar extends AbstractProduct {
    Guitar(String _brand, int _price) {
        super(_brand, _price);
        this.productType = "Guitar";
    }

    @Override
    public String serializeObj() {
        return "Guitar#" + this.brand + "#" + this.price;
    }

    @Override
    public String toString() {
        return String.format("Id: %d |Product: %s | Brand: %s | Price: %d HUF", this.id, this.productType, this.brand, this.price);
    }


    @Override
    public AbstractProduct updateWithCorrectType(String brand, int price) {
        return new Guitar(brand, price);
    }
}
