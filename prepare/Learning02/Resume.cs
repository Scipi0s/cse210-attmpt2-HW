public class Resume
{
    public string _employeeName = "Andrew Spinx";
    public List<Job> _jobList = new List<Job>();

    public void DisplayList()
    {
        Console.WriteLine($"{_employeeName}: ");
        foreach(Job job in _jobList)
        {
            job.DisplayInfo();
        }
    } 
}