using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        //Console.WriteLine("Please enter a Magic Number");
        //string answerString = Console.ReadLine();
        //int answer = int.Parse(answerString);
        Random magicnumber = new Random();
        int answer = magicnumber.Next(1,10); 
        int guess = -1;

        while(guess != answer)
        {
        Console.WriteLine("What is your guess? ");
        string guessString = Console.ReadLine();
        guess = int.Parse(guessString);

        if(guess > answer)
        {
            Console.WriteLine("Lower");
        }
        else if(guess < answer)
        {
            Console.WriteLine("Higher");
        }
        else
        {
            Console.WriteLine("You got it!");
        }
        }
    }
}