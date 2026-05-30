using System.Security.Cryptography;

public class Address
{
    private string _streetAddress;

    private string _city;

    private string _province;

    private string _country;

    public Address(string streetAddress, string city, string province, string country)
    {
        _streetAddress=streetAddress;
        _city=city;
        _province=province;
        _country=country;
    }

    public string GetDisplayAddress()
    {
        return "Street address: "+_streetAddress+"\n"+"City: "+_city+"\n"+"State/province: "+_province+"\n"+"Country: "+_country;
    }

    public string GetDisplayAddressShippingLabel()
    {
        return _streetAddress+"\n"+_city+"\n"+_province+"\n"+_country;
    }

    public bool CheckCountry()
    {
        if (_country == "USA")
        {
            return true;
        }

        return false;

    }






}