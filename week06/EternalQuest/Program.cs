// exceeding requirements adding leveling system, logic in GoalManager.cs, every 1000 goals adds 1 level
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest - Main Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");

            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;
                case "2":
                    manager.DisplayGoals();
                    Pause();
                    break;
                case "3":
                    RecordGoalEvent(manager);
                    break;
                case "4":
                    Console.WriteLine($"Current Score: {manager.GetScore()}");
                    // display leveling system
                    Console.WriteLine($"Current Level: {manager.GetLevel()}");
                    Pause();
                    break;
                case "5":
                    running = false;
                    break;
                case "6":
                    Console.Write("Enter filename to save: ");
                    string saveFile = Console.ReadLine();
                    manager.SaveGoals(saveFile);
                    Console.WriteLine("Goals saved.");
                    Pause();
                    break;
                case "7":
                    Console.Write("Enter filename to load: ");
                    string loadFile = Console.ReadLine();
                    manager.LoadGoals(loadFile);
                    Console.WriteLine("Goals loaded.");
                    Pause();
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    Pause();
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.WriteLine("\nSelect Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Your choice: ");
        string type = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                manager.AddGoal(new SimpleGoal(name, desc, points));
                break;
            case "2":
                manager.AddGoal(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("How many times to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Pause();
    }

    static void RecordGoalEvent(GoalManager manager)
    {
        Console.WriteLine("\nWhich goal did you complete?");
        manager.DisplayGoals();
        Console.Write("Enter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        manager.RecordEvent(index);
        Console.WriteLine("Goal recorded!");
        Pause();
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...\n");
        Console.ReadLine();
    }
}
