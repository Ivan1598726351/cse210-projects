public class Product
{
    private string _productName;

    private int _productId;

    private int _productPrice;

    private int _productQuantity;

    public Product(string productName, int productId, int productPrice, int productQuantity)
    {
        _productName=productName;
        _productId=productId;
        _productPrice=productPrice;
        _productQuantity=productQuantity;
    }

    public string GetDisplayProduct()
    {
        return "Product name: "+_productName+"\n"+"Product ID: "+_productId+"\n"+"Product price: "+_productPrice+"$"+"\n"+"Product Quantity: "+_productQuantity;        
    }

    public int ProductPrice()
    {
        return _productPrice*_productQuantity;
    }

    public string GetDisplayProductName()
    {
        return _productName;
    }

    public int GetDisplayProductId()
    {
        return _productId;
    }

}