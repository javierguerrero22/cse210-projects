using System;

class Video
{
    private string _title;
    private string _author;
    private int _duration;
    private List<Comment> _comments;

    public Video(string title, string author, int duration) {
        _title = title;
        _author = author;
        _duration = duration;
        _comments = new List<Comment>() ;

    }
    public int GetCommentCount() {
        return _comments.Count;
    }

    public void AddComment(Comment comment ) {
        _comments.Add(comment);
    }

    public void DisplayInfo(){
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_duration}");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        Console.WriteLine("Comments: ");
        foreach (var comment in _comments){
            Console.WriteLine($"- {comment.DisplayComment()}");
        }
    }
}
