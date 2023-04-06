public class Breathing : Meditation
{
    private string _startingMessage;

    private string _endingMessage;

    public Breathing(string startingMessage, string endingMessage) : base(startingMessage,endingMessage)
    {
        this._startingMessage = startingMessage;
        this._endingMessage = endingMessage;        
    }

    public override string GetStartingMessage()
    {
        //string _startingMessage = "This activity is designed to help you focus on your breathing and relax, take the time to open your mind as we guide you along."; 
        return _startingMessage;
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
        //_endingMessage = "Thank you for participating in this Breathing exercise, we hope you feel calmer and more relaxed now.";
        return _endingMessage;
    }
}