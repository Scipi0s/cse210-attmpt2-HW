using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6,7);

        Console.WriteLine(f1.GetFraction());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFraction());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFraction());
        Console.WriteLine(f3.GetDecimalValue());
    }
}