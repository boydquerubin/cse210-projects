using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video();
        video1._title = "How to tie shoelaces";
        video1._author = "Samuel Costa";
        video1._length = 100;

        Video video2 = new Video();
        video2._title = "How to cook spaghetti";
        video2._author = "Brendan Brady";
        video2._length = 300;

        Video video3 = new Video();
        video3._title = "How to breakdance";
        video3._author = "Anna Thurston";
        video3._length = 500;

        Video video4 = new Video();
        video4._title = "How to cook chicken";
        video4._author = "Ugochukwu Febechukwu";
        video4._length = 200;

        Comment comment1 = new Comment();
        comment1._comment = "this video is great!";
        comment1._comment.Add(video1);
    }
}