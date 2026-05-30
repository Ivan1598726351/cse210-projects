using System.Dynamic;

public class Order
{
    private List <Product> _products= new List <Product> ();

    private Customer _customer;

    public Order(Customer customer)
    {
        _customer=customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public string GetPackingLabel()
    {
        string packigingLabel ="";
        foreach (Product product in _products)
        {
            packigingLabel=packigingLabel+"\n"+product.GetDisplayProductName()+"-"+"Product ID: "+product.GetDisplayProductId();
        }
        return "Packiging Label: "+packigingLabel;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:"+"\n"+_customer.GetDisplayCustomerName()+"\n"+_customer.GetDisplayCustomerAddress();
    }

    public int TotalPriceOrder()
    {
        int shippingCost=0;
        int sumProduct=0;
        if (_customer.LivingInUSA() == true)
        {
            shippingCost=5;
        }

        else
        {
            shippingCost=35;
        }

        foreach(Product product in _products)
        {
            sumProduct=sumProduct+product.ProductPrice();
        }
        return sumProduct+shippingCost;
    }    


}