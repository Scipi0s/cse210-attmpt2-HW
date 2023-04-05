public class Event
{
    private string _eventTitle;
    private string _eventType;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private string _eventAddress;

    public Event(string eventTitle, string eventType, string eventDescription, string eventDate, string eventTime, string eventAddress)
    {
        _eventTitle = eventTitle;
        _eventType = eventType;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
        _eventAddress = eventAddress;
    }

    public string GetStandardDetails()
    {
        return $"Event:{_eventTitle}, {_eventDescription} When: {_eventDate} at {_eventTime}, Where:{_eventAddress}";
    }

    public string GetFullDetails()
    {
        return $"Event: {_eventTitle}, Event Type: {_eventType}, {_eventDescription} When: {_eventDate} at {_eventTime}, Where:{_eventAddress}";
    }

    public string GetShortDetails()
    {
        return $"Event: {_eventTitle}, Event Type: {_eventType}, When: {_eventDate}";
    }
}