public class Customer
{
    private string _customerName;

    private Address _address;

    public Customer(string customerName, Address address)
    {
        _customerName=customerName;
        _address=address;   
    }


    public string GetDisplayCustomer()
    {
        return "Customer name: "+_customerName+"\n"+_address.GetDisplayAddress();
    }

    public string GetDisplayCustomerName()
    {
        return _customerName;
    }

    public string GetDisplayCustomerAddress()
    {
        return _address.GetDisplayAddressShippingLabel();
    }
    public bool LivingInUSA()
    {
        return _address.CheckCountry();
    }


}