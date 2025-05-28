public class Comment
{
    public string _name;
    public string _comment;

    // public Comment()
    // {
    //     comment1 = _comment;
    //     comment2 = _comment;
    //     comment3 = _comment;
    //     comment4 = _comment;
    // }
    
    public void DisplayComment()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Comment: {_comment}");
    }    
}