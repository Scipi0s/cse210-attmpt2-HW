using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Welcome to the Numbers List. ");

        List<int> numbers = new List<int>();
        int entry = -1;
        int end = 0;
        while(entry != end)
        {
            Console.WriteLine("What number do you want to add to the list? ");
            string entryString = Console.ReadLine();
            entry = int.Parse(entryString);
            numbers.Add(entry);
        }

        int total =0;
        foreach(int number in numbers)
        {
            total += number;
  
        }

        int maxNum = numbers[0];
        foreach(int number in numbers)
        {
            if(number>maxNum)
            {
                maxNum = number;
            }
        }
        Console.WriteLine($"total: {total}");
        int average = total/numbers.Count;
        Console.WriteLine($"average: {average}");
        Console.WriteLine($"highest number {maxNum}");

    }
}