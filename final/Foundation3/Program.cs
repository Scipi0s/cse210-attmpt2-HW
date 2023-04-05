using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        Lecture lecture1 = new Lecture("How to Manage Your Modern Expectations","Lecture","A riveting lesson with Wade Bogs on how to properly manage your expectations in the modern age.","Monday Jan 18, 2023","6 p.m. MDT","3","Wade Boggs","30 Adults");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetShortDetails());

        Outdoor outdoor2 = new Outdoor("YSA 36th Ultimate Baseball Championship","Outdoor","A ward activity featuring a 5 team ultimate frisbee tournament.","July 5 2023","6:30 p.m.","2","Sunny, 60 degrees");
        Console.WriteLine(outdoor2.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor2.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor2.GetShortDetails());

        Reception reception3 = new Reception("Wedding Reception for Logan Crittenden and Clara Hodgson","Reception","The wedding reception for Logan and Clara.","April 13 2023","6:00 p.m.","371","lguitarist2001@gmail.com");
        Console.WriteLine(reception3.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception3.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(reception3.GetShortDetails());                
    }
}