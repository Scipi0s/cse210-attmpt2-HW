public class Entry
{
  public List<string> _promptsList = new List<string>()
    {"Favorite class?", "Favorite programming language?", "What did you have for breakfast?", "What is your favorite part of your major?", "Favortie thing learned in class?"};
    
    public string NewEntry()
    {
    Random promptNumber = new Random();
    DateTime currentDate = DateTime.Now;
    string entryDate = currentDate.ToShortDateString();
    int promptchoice = promptNumber.Next(0,5);
    string newPrompt = _promptsList.ElementAt(promptchoice);
    Console.WriteLine($"{newPrompt} ");
    string userResponse = Console.ReadLine();
    string finishedEntry = $"{entryDate}- Prompt:{newPrompt} - {userResponse}";
    return finishedEntry;
    }
}