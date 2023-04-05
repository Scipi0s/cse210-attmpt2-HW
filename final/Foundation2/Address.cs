public class Address
{
    private string _streetAddress;
    private string _cityName;
    private string _stateOrProvince;
    private string _countryName;
    private string _customerAddress;

    public Address(string streetAddress, string cityName, string stateOrProvince, string countryName)
    {
        this._streetAddress = streetAddress;
        this._cityName = cityName;
        this._stateOrProvince = stateOrProvince;
        this._countryName = countryName; 
    }

    // public string GetStreetAddress()
    // {
    //     return _streetAddress;
    // }

    // public void SetStreetAddress(string streetAddress)
    // {
    //     _streetAddress = streetAddress;
    // }

    // public string GetCityName()
    // {
    //     return _cityName;
    // }

    // public void SetCityName(string cityName)
    // {
    //     _cityName = cityName;
    // }

    // public string GetStateOrProvince()
    // {
    //    return _stateOrProvince;
    // }

    // public void SetStateOrProvince(string stateOrProvince)
    // {
    //     _stateOrProvince = stateOrProvince;
    // }

    public string GetCountry()
    {
        return _countryName;
    }

    // public void SetCountry(string countryName)
    // {
    //     _countryName = countryName;
    // }

    public string GetFullAddress()
    {
        return _customerAddress;
    }

// public void SetCustomerAddress(string customerAddress)
// {
//     _customerAddress = customerAddress;
// }

    public string SetProfileAddress(string streetAddress, string cityName, string stateOrProvince, string countryName)
    {
        _customerAddress = $"{streetAddress} {cityName}, {stateOrProvince} {countryName}";
        return _customerAddress;
    }
}