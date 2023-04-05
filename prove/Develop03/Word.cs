public class Word
{
    private string _word;
    private bool _isHidden;

    public void HideWord()
    {
        _isHidden = false;
    }

    public void ShowWord()
    {
        _isHidden = true;
    }

    public string GetText(string _word)
    {
        if(_isHidden == false)
        {
            _word = "_____";
            return _word;
        }
        else
        {
            return _word;
        }
    }
}