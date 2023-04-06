public abstract class Meditation
{
    private string _startingMessage;
    private string _endingMessage;
    //private int _duration;
    //private string _pausingAnimation; 

    public Meditation(string startingMessage, string endingMessage)
    {
        this._startingMessage = startingMessage;
        this._endingMessage = endingMessage;

    }

    public virtual string GetStartingMessage()
    {
        return _startingMessage;
    }

    public virtual string GetEndingMessage()
    {
        return _endingMessage;
    }


    public abstract void GetPausingAnimation();
    
}