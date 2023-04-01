using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video();
        video1.video_Author = "Ben Davis";
        video1.video_Title = "Playing FFXVI for Charity";
        video1.video_Length = "2700";
        Comment vid1comments = new Comment();
        string comment1 = vid1comments.NewComment("Gary69","Great video, would watch again!");
        string comment2 = vid1comments.NewComment("BigD420","Not my style, subscriber lost.");
        string comment3 = vid1comments.NewComment("Anonymous39","Thank you for mentioning my dontation!");
        video1.video_Comments.Add(comment1);
        video1.video_Comments.Add(comment2);
        video1.video_Comments.Add(comment3);

        Video video2 = new Video();
        video2.video_Author = "Markiplier";
        video2.video_Title = "At The Movies with Markiplier";
        video2.video_Length = "5400";
        Comment vid2comments = new Comment();
        string comment4 = vid2comments.NewComment("JackieBoy","The next greatest masterpiece!");
        string comment5 = vid2comments.NewComment("BobWilde","Hey look! I made it in the movie!");
        string comment6 = vid2comments.NewComment("muyskerm","Pleasure doing business with ya Mark!");
        video2.video_Comments.Add(comment4);
        video2.video_Comments.Add(comment5);
        video2.video_Comments.Add(comment6);

        Video video3 = new Video();
        video3.video_Author = "Jacksepticeye";
        video3.video_Title = "Happy Wheels Episode 6900";
        video3.video_Length = "2100";
        Comment vid3comments = new Comment();
        string comment7 = vid2comments.NewComment("DanielTheChad","Another Wonderful Episode!");
        string comment8 = vid2comments.NewComment("WildeStallion","Should've used the old man, you could've won that way");
        string comment9 = vid2comments.NewComment("BabyDoll","You're so hot, please marry me!!<3");
        video3.video_Comments.Add(comment7);
        video3.video_Comments.Add(comment8);
        video3.video_Comments.Add(comment9);

        video1.DisplayVideoInfo();
        video1.DisplayCommentCount();
        video1.DisplayCommentsSection();

        video2.DisplayVideoInfo();
        video2.DisplayCommentCount();
        video2.DisplayCommentsSection();
        
        video3.DisplayVideoInfo();
        video3.DisplayCommentCount();
        video3.DisplayCommentsSection();
    }
}