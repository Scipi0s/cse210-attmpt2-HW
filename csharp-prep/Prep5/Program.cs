using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNum();
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(userName, numberSquared);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your Name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNum()
    {
        Console.WriteLine("What is your Favorite number? ");
        string numString = Console.ReadLine();
        int number = int.Parse(numString);
        return number;
    }
    
    static int SquareNumber(int number)
    {
        int userNumber = number;
        int result = userNumber * userNumber;
        return result;
    }

    static void DisplayResult(string userName, int result)
    {
        Console.WriteLine($"{userName}, the square of your number is {result}. ");
    }
}