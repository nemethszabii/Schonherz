public abstract class AbstractProduct implements IProduct {
    protected int id;
    protected int price;
    protected String brand;
    protected String productType;

    AbstractProduct(String _brand, int _price) {
        this.brand = _brand;
        this.price = _price;
    }

    @Override
    public int getId() {
        return this.id;
    }

    @Override
    public void setId(int value) {
        if (value > 0) {
            this.id = value;
        }
    }

    @Override
    public String getBrand() {
        return this.brand;
    }

    @Override
    public int getPrice() {
        return this.price;
    }

    @Override
    public void setBrand(String value) {
        if (!value.isEmpty()) {
            this.brand = value;
        }
    }

    @Override
    public void setPrice(int value) {
        if (value > 0) {
            this.price = value;
        }
    }

    @Override
    public abstract String serializeObj();
    public abstract AbstractProduct updateWithCorrectType(String brand, int price);
}
