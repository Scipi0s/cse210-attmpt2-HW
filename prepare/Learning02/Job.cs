public class Job
{
    public string _jobTitle;
    public string _companyName;
    public int _startYear;
    public int _endYear;

    public void DisplayInfo()
    {
        Console.WriteLine($"{_jobTitle}: ({_companyName})");
    }
}