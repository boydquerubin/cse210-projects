public class GratitudeActivity : Activity
{
    private List<string> _prompts;
    private Random _rand = new Random();

    public GratitudeActivity(string name, string description, List<string> prompts)
        : base(name, description, 0)
    {
        _prompts = prompts;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine($"\nTake a moment to reflect on this:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\nBegin listing your thoughts (press Enter after each):");
        Countdown(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} things you're grateful for.");
        DisplayEndingMessage();
    }
}
