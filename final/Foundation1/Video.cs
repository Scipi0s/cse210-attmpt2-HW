public class Video
{
    public string video_Title;
    public string video_Length;
    public string video_Author;
    public List <string> video_Comments = new List<string>();

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title:{video_Title}, Author:{video_Author}, Length:{video_Length} seconds");
    }

    public void DisplayCommentCount()
    {
        Console.WriteLine(video_Comments.Count);
    }

    public void DisplayCommentsSection()
    {
        foreach(string comment in video_Comments)
        {
            Console.WriteLine(comment);
        } 
    }
}