using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to tie shoelaces", "Samuel Costa", 100);
        video1.AddComment(new Comment("Alice", "Great video!"));
        video1.AddComment(new Comment("Bob", "This helped a lot!"));
        video1.AddComment(new Comment("Charlie", "Thank you!"));
        videos.Add(video1);

        Video video2 = new Video("How to cook Spaghetti", "Brendan Brady", 300);
        video2.AddComment(new Comment("Dave", "This helped so much."));
        video2.AddComment(new Comment("Frank", "Clear and easy to follow."));
        videos.Add(video2);

        Video video3 = new Video("How to Breakdance", "Anna Thurston", 500);
        video3.AddComment(new Comment("Grace", "I was looking for a video like this!"));
        videos.Add(video3);

        Video video4 = new Video("How to cook Chicken", "Ugochukwu Febechukwu", 200);
        video4.AddComment(new Comment("Jack", "This video is great!"));
        video4.AddComment(new Comment("Jill", "So good!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}