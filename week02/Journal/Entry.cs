public class Entry
{
    public string _date;
    public string _entry;
    // exceeding requirements: added mood
    public string _mood;


    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Mood: {_mood}");
        Console.WriteLine($"Entry: {_entry}\n");
    }
}