using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Assignment work = new Assignment("Zach", "Social Studies");
        Console.WriteLine(work.GetSummary());

        MathAssignment mathWork = new MathAssignment("Jose","Calculus","7.3","8-11");
        Console.WriteLine(mathWork.GetSummary());
        Console.WriteLine(mathWork.GetHomeworkList());

        WritingAssignment bookReport = new WritingAssignment("Jessie", "Writing","Review of War & Peace");
        Console.WriteLine(bookReport.GetSummary());
        Console.WriteLine(bookReport.GetWritingInfo());
    }
}