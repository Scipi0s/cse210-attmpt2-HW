public class Comment
{

    public string NewComment(string commentor_Name, string comments_Text)
    {
        string commenter_Name = commentor_Name;
        string comment_Text = comments_Text;
        string comment_Info = $"{commentor_Name}: {comments_Text}";

        return comment_Info;
    }
}