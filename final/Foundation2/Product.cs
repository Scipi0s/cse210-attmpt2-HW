public class Product
{
    private string _itemName;

    private string _itemID;
    private double _itemPrice;
    private int _itemQuantity;

    public Product(string itemName, string itemID, double itemPrice, int itemQuantity)
    {
        this._itemName = itemName;
        this._itemID = itemID;
        this._itemPrice = itemPrice;
        this._itemQuantity = itemQuantity;
    }
    

    public string GetName()
    {
        return _itemName;
    }

    public string GetID(string itemID)
    {
        return _itemID;
    }

    public double GetPrice(double itemPrice)
    {
        return _itemPrice;
    }

    public int GetQuantity(int itemQuantity)
    {
        return _itemQuantity;
    }

    public double GetItemTotal()
    {
        double _itemTotal = _itemPrice * _itemQuantity;
        return _itemTotal;
    }

    public string GetProductLabel()
    {
        return $"Product: {_itemName}, ID: {_itemID}";
    }
}