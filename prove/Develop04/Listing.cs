public class Listing : Meditation
{
    private string _startingMessage;

    private string _endingMessage;


    public Listing(string startingMessage, string endingMessage) : base(startingMessage, endingMessage)
    {
        this._startingMessage = startingMessage;
        this._endingMessage = endingMessage;

    }

    public override string GetStartingMessage()
    {
        return _startingMessage;
    }

    public string SelectListingPrompt()
    {
        List<string> _listingPrompts = new List<string>()
        {
            "What are your greatest strengths?",
            "Who are the people in your life you appreciate the most?",
            "What are some of your achievements from this week?"
        };
        Random num3 = new Random();
        int _listindex = num3.Next(0, 2);
        string _promptChoice = _listingPrompts[_listindex];
        return _promptChoice;
    }

    public override void GetPausingAnimation()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public override string GetEndingMessage()
    {
        return _endingMessage;
    }
}