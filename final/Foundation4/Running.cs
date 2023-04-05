public class Running : Activity
{
    private double _distance;
    private int _minutes;
    private int _pace;

    public Running(int pace, int speed, double distance, string activityDate,  int minutes) : base(pace, speed, activityDate, minutes, distance)
    {
        _distance = distance;
        _minutes = minutes;
        _pace = pace;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }

    public override double GetSpeed()
    {
        return 60 / _pace;
    }
    public override string GetSummary()
    {
        return $"{GetActivityDate()}: Duration:{_minutes}, Distance{_distance}miles, Speed:{GetSpeed()} mph, Pace:{_pace} min per mile.";
    }
}