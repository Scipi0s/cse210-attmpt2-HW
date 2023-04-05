public class Order
{
    // private double _shippingCost;
    private double _orderTotal;
    private List<Product> productList;
    private Customer newProfile;

    public Order(List<Product> productList, Customer newProfile)
    {
        this.productList = productList;
        this.newProfile = newProfile;
    }
    

    // public double GetShippingCost()
    // {
    //     return _shippingCost;
    // }


    public string GetShippingLabel()
    {
        return newProfile.GetProfile();
    }

    public void GetPackingLabel()
    {
        foreach(Product product in productList)
        {
            Console.WriteLine(product.GetProductLabel());
        }
    }

    public double GetOrderTotal()
    {
        return _orderTotal;
    }

    public double SetOrderTotal()
    {
        foreach(Product product in productList)
        {
            _orderTotal += product.GetItemTotal();
        }
        _orderTotal += newProfile.IsInUSA() ? 5:35;
        return _orderTotal;
    }
}