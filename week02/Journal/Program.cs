using System;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Entry> entries = new List<Entry>();

        while (true)
        {
            Console.WriteLine("Enter the number of the option you want.");
            Console.WriteLine("1. Write entry");
            Console.WriteLine("2. Display entry");
            Console.WriteLine("3. Exit");
            string input = Console.ReadLine();

            if (input == "1")
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                Entry entry = new Entry();
                Console.Write("Response: ");
                entry._entry = Console.ReadLine();

                // exceeding requirements: added mood
                Console.Write("How are you feeling today?: ");
                entry._mood = Console.ReadLine();

                Console.Write("Enter the date: ");
                entry._date = Console.ReadLine();             

                entries.Add(entry);
                SaveToFile(entries);
            }
            else if (input == "2")
            {
                List<Entry> savedEntries = ReadFromFile();
                Journal journal = new Journal();
                journal._journal = savedEntries;
                journal.DisplayEntry();
            }
            else if (input == "3")
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }
    }

    public static void SaveToFile(List<Entry> entries)
    {
        Console.WriteLine("Saving to file...");

        string filename = "entries.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                // exceeding requirements: added mood
                outputFile.WriteLine($"{entry._date}|{entry._mood}|{entry._entry}");
            }
        }
    }

    public static List<Entry> ReadFromFile()
    {
        Console.WriteLine("Reading  to file...");

        List<Entry> entries = new List<Entry>();

        string filename = "entries.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Console.WriteLine(line);
            string[] parts = line.Split("|");

            if (parts.Length == 3)
            {
                Entry newEntry = new Entry();
                newEntry._date = parts[0];
                // exceeding requirements: added mood
                newEntry._mood = parts[1];
                newEntry._entry = parts[2];

                entries.Add(newEntry);
            }
        }

        return entries;
    }
}