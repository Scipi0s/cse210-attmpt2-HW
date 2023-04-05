public class Customer
{
    
    private string _customerName;
    private Address newAddress;

    public Customer(string customerName, Address newAddress)
    {
        this._customerName = customerName;
        this.newAddress = newAddress;

    }

    public string GetCustomerName()
    {
        return _customerName;
    }


    public string GetProfile()
    {
  
        string profileAddress = newAddress.GetFullAddress();
        string _customerProfile = $"{_customerName}, {profileAddress}";
        return _customerProfile;
    }

    public bool IsInUSA()
    {
        return newAddress.GetCountry()=="USA";
    }
}