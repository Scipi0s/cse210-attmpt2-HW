using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What grade percentage did you receive? ");
        string gradeString = Console.ReadLine();
        int gradeNumber = int.Parse(gradeString);
        string letter = "";
        if(gradeNumber >= 90)
        {
            letter = "A";
        }
        else if(gradeNumber >= 80)
        {
            letter = "B";
        }
        else if(gradeNumber >= 70)
        {
            letter = "C";
        }
        else if(gradeNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        if (gradeNumber >= 70)
        {
            Console.WriteLine($"Grade: {letter}, You Passed!");
        }
        else
        {
            Console.WriteLine($"Grade: {letter}, not enough, Keep Trying!");
        }
    }
}