using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video1 = new Video("C# Tutorial", "Javier Guerrero", 650);
        video1.AddComment(new Comment("Alice", "Great tutorial!"));

        Video video2 = new Video("Py Tutorial", "Alejandro Jiménez", 425);

        Video video3 = new Video("Js Tutorial", "Javier Jiménez", 850);
        video3.AddComment(new Comment("Sammy", "This video is what I was looking for!"));
        video3.AddComment(new Comment("Sam", "The best video ever!"));
        video3.AddComment(new Comment("Alison", "Good!"));
        video3.AddComment(new Comment("Robert", "Thanks for this awesome tutorial!"));

        Video video4 = new Video("C# Classes", "Alejandro Guerrero", 777);
        video4.AddComment(new Comment("Sara", "I was confused before this video"));
        video4.AddComment(new Comment("Gabriel", "The best explanation ever!"));
        video4.AddComment(new Comment("Bob", "Very helpful!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
        Console.WriteLine();
    }
}