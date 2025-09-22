public class ProductDoesNotExist extends RuntimeException {
    public ProductDoesNotExist() {
        super("Product with this id does not exist!");
    }
}
