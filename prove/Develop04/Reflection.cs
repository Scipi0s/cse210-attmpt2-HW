public class Reflection : Meditation
{
    private string _startingMessage;

    private string _endingMessage;


    public Reflection(string startingMessage, string endingMessage) : base(startingMessage, endingMessage)
    {
        this._startingMessage = startingMessage;
        this._endingMessage = endingMessage;
    }

    public override string GetStartingMessage()
    {
        return _startingMessage;
    }

    // public override int GetDuration()
    // {
    //     Console.WriteLine("How long would you like to reflect for? ");
    //     int _duration = int.Parse(Console.ReadLine()); 
    //     return _duration;
    // }

    public string SelectReflectPrompt()
    {
        List<string> _reflectQuotes = new List<string>()
        {
            "When was there a time you overcame something difficult",
            "When did you help someone in need?",
            "When was there a time you felt your lowest?"

        };
        Random num1 = new Random();
        int _listindex = num1.Next(0, 2);
        string _promptChoice = _reflectQuotes[_listindex];
        return _promptChoice;
    }

    public string SelectReflectQuestions()
    {
       List<string> _reflectQuestions = new List<string>()
        {
            "How did you react? ",
            "What about you grew from that experience",
            "What could you do different now?"

        };
        Random num2 = new Random();
        int _listindex = num2.Next(0, 2);
        string _questionChoice = _reflectQuestions[_listindex];
        return _questionChoice;
    }

    public override void GetPausingAnimation()
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        foreach (string s in animationStrings)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime startTime = DateTime.Now;
        DateTime endTime= startTime.AddSeconds(10);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
 
        }
    }

    public override string GetEndingMessage()
    {
        return _endingMessage;
    }
}