public class Cycling : Activity
{
    private int _speed;
    private double _distance;
    private int _minutes;

    public Cycling(double pace, int speed, double distance, string activityDate,  int minutes) : base(pace, speed, activityDate, minutes, distance)
    {
        _speed = speed;
        _distance = distance;
        _minutes = minutes;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }
    public override string GetSummary()
    {
        return $"{GetActivityDate()}: Duration:{_minutes}, Distance{_distance}miles, Speed:{GetSpeed()} mph, Pace:{GetPace()} min per mile.";
    }
}