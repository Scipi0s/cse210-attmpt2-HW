public abstract class Activity
{
    private double _pace;
    private int _speed;
    private string _activityDate;
    private int _minutes;
    private double _distance;

    public Activity(double pace, int speed, string activityDate, int minutes, double distance)
    {
        _pace = pace;
        _speed = speed;
        _activityDate = activityDate;
        _minutes = minutes;
        _distance = distance;
    }

    public virtual double GetPace()
    {
        return _pace;
    }
    public virtual double GetSpeed()
    {
        return _speed;
    }
    public virtual double GetDistance()
    {
        return _distance;
    }

    public virtual string GetActivityDate()
    {
        return _activityDate;
    }

    public virtual int GetMinutes()
    {
        return _minutes;
    }
    public abstract string GetSummary(); 
}