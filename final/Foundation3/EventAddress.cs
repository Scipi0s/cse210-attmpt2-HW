public class Address
{
    private string _selectAddress;

    public void GetSelectedAddress(string selectAddress)
    {
        _selectAddress = selectAddress;
    }

    public string SetSelectAddress(string selectAddress, string eventType)
    {
        if(eventType == "Lecture")
        {
            selectAddress = "PO Box 1580 S Lincoln St., Manchester, IL 60629";
        }

        else if(eventType == "Reception")
        {
            selectAddress = "371 Pinetree Rd., Rexburg, ID 83440";
        }

        else if(eventType == "Outdoor")
        {
            selectAddress = "S 2nd W & 3rd W, Rexburg, ID 83440 ";
        }

        return selectAddress;
    }
}