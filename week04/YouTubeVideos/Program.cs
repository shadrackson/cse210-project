using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C# in 30 Minutes", "Code Academy", 1200);
        video1.AddComment(new Comment("Azzard", "Very helpful!"));
        video1.AddComment(new Comment("Blitz", "I finally understand constructors."));
        video1.AddComment(new Comment("Chromson", "Excellent explanation."));
        videos.Add(video1);

        Video video2 = new Video("Top 10 C# Tips", "Programming Hub", 1500);
        video2.AddComment(new Comment("Davidson", "Very informative!"));
        video2.AddComment(new Comment("Esther", "I loved the examples."));
        video2.AddComment(new Comment("Frazzgaed", "Excellent summary."));
        videos.Add(video2);

        Video video3 = new Video("Programming valley", "Freecode Camp", 1400);
        video3.AddComment(new Comment("Getrude", "Now abstraction makes sense"));
        video3.AddComment(new Comment("Harriet", "Please make another video."));
        video3.AddComment(new Comment("Ivan", "Amazing lesson."));
        videos.Add(video3);

        Video video4 = new Video("Learn Software Development", "BYU Pathway", 1600);
        video4.AddComment(new Comment("Jackson", "Very inspiring!"));
        video4.AddComment(new Comment("Kelly Price", "Best learning experience."));
        video4.AddComment(new Comment("Leonardo", "This is the place to be."));
        videos.Add(video4);

        // Display everything
        foreach (Video video in videos)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();

        }  

        
    }
}
