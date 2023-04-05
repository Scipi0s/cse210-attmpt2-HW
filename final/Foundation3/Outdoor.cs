public class Outdoor : Event
{
    private string _weatherForecast;

    public Outdoor(string eventTitle, string eventType, string eventDescription, string eventDate, string eventTime, string eventAddress, string weatherForecast) : base (eventTitle, eventType, eventDescription, eventDate, eventTime, eventAddress)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetWeatherForecast()
    {
        return $"Expected Weather: {_weatherForecast}";
    }
}