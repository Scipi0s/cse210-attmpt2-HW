using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        List<Activity> activities = new List<Activity>();
        activities.Add(new Running(60,15,50,"03/24/2023",60));
        activities.Add(new Cycling(60,15,50,"03/25/2023",60));
        activities.Add(new Swimming(60,15,50,"03/26/2023",60,3));
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }                
    }


}