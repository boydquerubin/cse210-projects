using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge Him, and He shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            scripture.Display();
            // Creativity and exceeding requirements: Unhide words
            Console.WriteLine("Press 'Enter' to hide words, type 'u' + 'Enter' to unhide words, or type 'quit' + 'Enter' to exit.");
            string input = Console.ReadLine().ToLower();

            if (input == "quit")
                break;
            // Creativity and exceeding requirements: Unhide words
            else if (input == "u")
                scripture.UnhideRandomWords(1);
            else
                scripture.HideRandomWords(1);
        }

        Console.Clear();
        scripture.Display();
        Console.WriteLine("All words hidden. Goodbye!");
    }
}