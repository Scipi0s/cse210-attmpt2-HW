public class Reception : Event
{
    private string _emailRSVP;

    public Reception(string eventTitle, string eventType, string eventDescription, string eventDate, string eventTime, string eventAddress, string emailRSVP) : base (eventTitle, eventType, eventDescription, eventDate, eventTime, eventAddress)
    {
        _emailRSVP = emailRSVP;
    }

    public string GetRSVPEmail()
    {
        return $"Please RSVP to {_emailRSVP}";
    }
}