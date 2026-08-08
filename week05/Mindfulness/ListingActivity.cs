using System;
using System.Collections.Generic;

// ListingActivity inherits from Activity.
public class ListingActivity : Activity
{
    // List of possible prompts.
    private List<string> _prompts;

    // Random object for selecting a random prompt.
    private Random _random;

    // Constructor for ListingActivity.
    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    {
        // Create the Random object.
        _random = new Random();

        // Store the possible listing prompts.
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // This method runs the listing activity.
    public void Run()
    {
        // Display the common starting message.
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        // Select a random prompt.
        string prompt = GetRandomPrompt();

        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        // Give the user 5 seconds to think before starting.
        Console.WriteLine("You may begin in:");

        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine("Start listing items:");

        // Create a list to store everything the user enters.
        List<string> items = new List<string>();

        // Calculate when the activity should finish.
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        // Keep accepting answers until the time runs out.
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            // Read the user's answer.
            string item = Console.ReadLine();

            // Only add the answer if the user actually entered something.
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine();

        // Count how many items the user entered.
        Console.WriteLine($"You listed {items.Count} items.");

        // Display the common ending message.
        DisplayEndingMessage();
    }

    // Selects a random prompt from the prompt list.
    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }
}
