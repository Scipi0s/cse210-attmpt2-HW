public class Swimming : Activity
{
    private double _swimmingLaps;
    private double _distance;
    private int _minutes;

    public Swimming(int pace, int speed, double distance, string activityDate,  int minutes, double swimmingLaps) : base(pace, speed, activityDate, minutes, distance)
    {
        _swimmingLaps = swimmingLaps;
        _distance = distance;
        _minutes = minutes;
    }

    public override double GetDistance()
    {
        _distance = _swimmingLaps * 50 / 1000 * 0.62;
        return _distance;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
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