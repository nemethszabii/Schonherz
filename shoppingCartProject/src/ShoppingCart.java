import java.io.*;
import java.util.ArrayList;

public class ShoppingCart {
    private ArrayList<AbstractProduct> products;
    private int idx;

    ShoppingCart() {
        products = new ArrayList<>();
        idx = 1;
    }

    public ArrayList<AbstractProduct> getProducts() {
        if (products.isEmpty()) {
            throw new ShoppingCartEmpty();
        } else {
            return products;
        }
    }

    public boolean addProduct(AbstractProduct product) {
        if (product != null) {
            product.setId(idx);
            idx++;
            products.add(product);
            return true;
        }
        else {
            return false;
        }
    }

    public boolean updateProduct(int id, AbstractProduct updatedObj) {
        for (AbstractProduct p : products) {
            if (p.getId() == id) {
                p.setBrand(updatedObj.getBrand());
                p.setPrice(updatedObj.getPrice());
                return true;
            }
        }
        return false;
    }

    public boolean removeProduct(int id) {
        return products.removeIf(p -> p.getId() == id);
    }

    public AbstractProduct getProduct(int id) {
        for (AbstractProduct p : products) {
            if (p.getId() == id) {
                return p;
            }
        }
        throw new ProductDoesNotExist();
    }
}
