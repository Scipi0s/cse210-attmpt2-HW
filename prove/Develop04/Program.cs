using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Console.WriteLine("Welcome to the Live Easy Meditation program!");
        Console.WriteLine("How long would you like to meditate for?");
        int _duration = int.Parse(Console.ReadLine());
        int _millisecondDuration = _duration * 1000;

        DateTime end = DateTime.Now + new TimeSpan(0, 0, 0, 0, _millisecondDuration);

        while (DateTime.Now < end)
        {
            Console.Clear();
            Console.WriteLine("Choose an Exercise:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            int _exercise = int.Parse(Console.ReadLine());

            switch (_exercise)
            {
                case 1:
                Breathing newBreather = new Breathing("This activity is designed to help you focus on your breathing and relax, take the time to open your mind as we guide you along.", "Thank you for participating in this Breathing exercise, we hope you feel calmer and more relaxed now.");
                Console.WriteLine(newBreather.GetStartingMessage());
                Console.WriteLine("Breathe in...");
                newBreather.GetPausingAnimation();
                Console.WriteLine("Breate out...");
                newBreather.GetPausingAnimation();
                Console.WriteLine(newBreather.GetEndingMessage());
                break;

                case 2:
                Reflection newReflect = new Reflection("This activity is designed to help you reflect on powerful experiences in your life and how you reacted to them, feel free to prep your mind for this exercise.","Thank you for participating in today's Reflection Exercise");
                Console.WriteLine(newReflect.GetStartingMessage());
                Console.WriteLine(newReflect.SelectReflectPrompt());
                Console.WriteLine("Please reflect on these questions as they appear");
                Console.WriteLine(newReflect.SelectReflectQuestions());
                newReflect.GetPausingAnimation();
                Console.WriteLine(newReflect.SelectReflectQuestions());
                newReflect.GetPausingAnimation();
                Console.WriteLine(newReflect.SelectReflectQuestions());
                newReflect.GetPausingAnimation();
                Console.WriteLine(newReflect.GetEndingMessage());
                break;

                case 3:
                Listing newLister = new Listing("This exercise is meant to help you reflect on some of the good things in your life by having you list them off.","Thank you for participating in this Listing Exercise, we hope your appreciation of the good things in life has grown a little today!");
                List<string> listEntries = new List<string>();
                DateTime shortEnd = DateTime.Now + new TimeSpan(0, 0, 0, 0, (10*1000));
                Console.WriteLine(newLister.GetStartingMessage());
                Console.WriteLine(newLister.SelectListingPrompt());
                newLister.GetPausingAnimation();
                while (DateTime.Now < shortEnd)
                {
                    Console.WriteLine("Add something you are thinking of to the list: ");
                    listEntries.Add(Console.ReadLine());
                }
                Console.WriteLine(listEntries.Count);
                Console.WriteLine("Good Job!");
                Console.WriteLine(newLister.GetEndingMessage());
                break;

                case 4:
                    Console.WriteLine("Thanks for relaxing with us today!");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Invalid choice! Please choose again.");
                    break;                
            }
        }
        Console.WriteLine("Meditation program has ended. Press any key to exit...");
        Console.ReadKey();
    }
}