using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        QuestManager quest = new QuestManager();

        // This is the name of the file where the user's progress
        // will be saved.
        string filename = "eternalquest.txt";

        // This controls whether the program continues running.
        bool running = true;

        // Display a welcome message when the program starts.
        Console.WriteLine("================================");
        Console.WriteLine("       WELCOME TO ETERNAL QUEST");
        Console.WriteLine("================================");

        // Continue showing the menu until the user chooses Quit.
        while (running)
        {
            // Display the main menu.
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            // Use a switch statement to determine which
            // operation the user wants to perform.
            switch (choice)
            {
                case "1":
                    CreateGoal(quest);
                    break;

                case "2":
                    quest.DisplayGoals();
                    break;

                case "3":
                    RecordGoalEvent(quest);
                    break;

                case "4":
                    quest.DisplayScore();
                    break;

                case "5":
                    quest.Save(filename);
                    break;

                case "6":
                    quest.Load(filename);
                    break;

                case "7":
                    running = false;
                    Console.WriteLine("Thank you for using Eternal Quest!");
                    break;

                default:
                    // This handles an invalid menu choice.
                    Console.WriteLine(
                        "Invalid choice. Please select 1-7.");
                    break;
            }
        }
    }

    // This method allows the user to create a new goal.
    static void CreateGoal(QuestManager quest)
    {
        Console.WriteLine("\n===== CREATE NEW GOAL =====");

        // Ask the user which type of goal they want.
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Choose the goal type: ");
        string type = Console.ReadLine();

        // Get the common information required for all goals.
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter a short description: ");
        string description = Console.ReadLine();

        Console.Write("Enter the number of points: ");

        // TryParse prevents the program from crashing if
        // the user enters something that is not a number.
        if (!int.TryParse(Console.ReadLine(), out int points))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        // Create a SimpleGoal if the user selected option 1.
        if (type == "1")
        {
            // Create a new SimpleGoal object.
            SimpleGoal goal = new SimpleGoal(
                name,
                description,
                points);

            // Add the goal to the QuestManager.
            quest.AddGoal(goal);

            Console.WriteLine("Simple goal created successfully.");
        }

        // Create an EternalGoal if the user selected option 2.
        else if (type == "2")
        {
            // Create a new EternalGoal object.
            EternalGoal goal = new EternalGoal(
                name,
                description,
                points);

            // Add the goal to the QuestManager.
            quest.AddGoal(goal);

            Console.WriteLine("Eternal goal created successfully.");
        }

        // Create a ChecklistGoal if the user selected option 3.
        else if (type == "3")
        {
            Console.Write("How many times must you complete it? ");

            // Make sure the target count is a valid number.
            if (!int.TryParse(
                Console.ReadLine(),
                out int targetCount))
            {
                Console.WriteLine("Please enter a valid number.");
                return;
            }

            Console.Write("Enter the bonus points: ");

            // Make sure the bonus is a valid number.
            if (!int.TryParse(
                Console.ReadLine(),
                out int bonusPoints))
            {
                Console.WriteLine("Please enter a valid number.");
                return;
            }

            // Create the checklist goal.
            ChecklistGoal goal = new ChecklistGoal(
                name,
                description,
                points,
                targetCount,
                bonusPoints);

            // Add the goal to the QuestManager.
            quest.AddGoal(goal);

            Console.WriteLine(
                "Checklist goal created successfully.");
        }

        else
        {
            // Handle an invalid goal type.
            Console.WriteLine(
                "Invalid goal type. Goal was not created.");
        }
    }

    // This method allows the user to record an event
    // for one of their goals.
    static void RecordGoalEvent(QuestManager quest)
    {
        // First display the available goals.
        quest.DisplayGoals();

        Console.Write("\nWhich goal did you accomplish? ");

        // Make sure the user enters a valid number.
        if (!int.TryParse(
            Console.ReadLine(),
            out int goalNumber))
        {
            Console.WriteLine("Please enter a valid number.");
            return;
        }

        // Send the selected goal number to QuestManager.
        quest.RecordEvent(goalNumber);

        
    }
}
