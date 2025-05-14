using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter the number of the option you want.");
            Console.WriteLine("1. Write entry");
            Console.WriteLine("2. Display entry");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Entry date = new Entry();
                Entry entry = new Entry();
                Journal journal = new Journal();

                Console.Write("Enter the date: ");
                date._date = Console.ReadLine();
                Console.Write("Entry: ");
                entry._entry = Console.ReadLine();

                journal._journal.Add(date);
                journal._journal.Add(entry);

                journal.DisplayEntry();
            }
        }
    }
}