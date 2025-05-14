public class Entry
{
    public string _entry;
    public string _date;

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Entry: {_entry}");
    }
}