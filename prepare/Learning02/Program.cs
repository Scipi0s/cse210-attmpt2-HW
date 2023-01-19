using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Lead Programmer";
        job1._companyName = "Re:Logic";

        Job job2 = new Job();
        job2._jobTitle = "Company Executive Officer";
        job2._companyName = "Re:Logic";


        Resume resume1 = new Resume ();
        resume1._jobList.Add(job1);
        resume1._jobList.Add(job2);
        resume1.DisplayList();
    }
}