public class Shoe extends AbstractProduct {
    Shoe(String _brand, int _price) {
        super(_brand, _price);
        this.productType = "Shoe";
    }

    @Override
    public String serializeObj() {
        return "Shoe#" + this.brand + "#" + this.price;
    }

    @Override
    public AbstractProduct updateWithCorrectType(String brand, int price) {
        return new Shoe(brand, price);
    }

    @Override
    public String toString() {
        return String.format("Id: %d |Product: %s | Brand: %s | Price: %d HUF", this.id, this.productType, this.brand, this.price);
    }
}
