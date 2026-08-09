using System;
using System.Collections.Generic;
using System.IO;

// This class manages the user's goals, score, levels, and saved progress.
public class QuestManager
{
    // A list that stores all the goals created by the user.
    // The list uses the base Goal type, allowing it to store
    // SimpleGoal, EternalGoal, and ChecklistGoal objects.
    private List<Goal> _goals;

    // Stores the user's total number of points.
    private int _score;

    // Constructor creates a new quest with no goals and zero points.
    public QuestManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Adds a new goal to the user's list of goals.
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Returns the user's current score.
    public int GetScore()
    {
        return _score;
    }

    // Calculates the user's level based on their score.
    // Every 500 points increases the user's level.
    public int GetLevel()
    {
        return (_score / 500) + 1;
    }

    // Gives the user a title based on their current level.
    // This is one of our additional gamification features.
    public string GetLevelTitle()
    {
        int level = GetLevel();

        if (level >= 10)
        {
            return "Quest Master";
        }
        else if (level >= 5)
        {
            return "Eternal Champion";
        }
        else if (level >= 3)
        {
            return "Faithful Worker";
        }
        else
        {
            return "Beginner";
        }
    }

    // Displays all of the user's goals.
    public void DisplayGoals()
    {
        // Check whether the user has created any goals.
        if (_goals.Count == 0)
        {
            Console.WriteLine("You don't have any goals yet.");
            return;
        }

        Console.WriteLine("\nYour Goals:");

        // Loop through the list and display each goal.
        for (int i = 0; i < _goals.Count; i++)
        {
            // Add 1 because list indexes start at 0,
            // but users normally number things starting at 1.
            Console.WriteLine(
                $"{i + 1}. {_goals[i].GetDisplayString()}");
        }
    }

    // Records an event for the selected goal.
    public void RecordEvent(int goalNumber)
    {
        // Convert the user's goal number into a list index.
        int index = goalNumber - 1;

        // Make sure the selected goal actually exists.
        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        // Get the selected goal.
        Goal goal = _goals[index];

        // This demonstrates polymorphism.
        // We don't need to know whether the goal is a
        // SimpleGoal, EternalGoal, or ChecklistGoal.
        // Each class knows how to record its own event.
        int earnedPoints = goal.RecordEvent();

        // Add the points to the user's total score.
        if (earnedPoints > 0)
        {
            _score += earnedPoints;

            Console.WriteLine(
                $"Congratulations! You earned {earnedPoints} points.");

            Console.WriteLine(
                $"Total Score: {_score}");

            Console.WriteLine(
                $"Level: {GetLevel()} - {GetLevelTitle()}");
        }
        else
        {
            // This normally happens when a completed
            // SimpleGoal or ChecklistGoal is recorded again.
            Console.WriteLine(
                "This goal has already been completed.");
        }
    }

    // Saves the user's score and goals to a text file.
    public void Save(string filename)
    {
        // StreamWriter allows us to write information to a file.
        using (StreamWriter writer = new StreamWriter(filename))
        {
            // Save the score as the first line.
            writer.WriteLine(_score);

            // Save each goal on its own line.
            foreach (Goal goal in _goals)
            {
                // Each goal creates its own save string.
                // This is another example of polymorphism.
                writer.WriteLine(goal.GetSaveString());
            }
        }

        Console.WriteLine("Quest saved successfully.");
    }

    // Loads the user's previous progress from a file.
    public void Load(string filename)
    {
        // Check whether the save file exists.
        if (!File.Exists(filename))
        {
            Console.WriteLine("Save file was not found.");
            return;
        }

        // Read every line from the file.
        string[] lines = File.ReadAllLines(filename);

        // Make sure the file is not empty.
        if (lines.Length == 0)
        {
            Console.WriteLine("Save file is empty.");
            return;
        }

        // The first line contains the user's score.
        _score = int.Parse(lines[0]);

        // Remove any goals that might already be in memory.
        _goals.Clear();

        // Start at line 1 because line 0 contains the score.
        for (int i = 1; i < lines.Length; i++)
        {
            // Separate the information using the | character.
            string[] parts = lines[i].Split('|');

            // The first part tells us what type of goal we have.
            string goalType = parts[0];

            // Re-create a SimpleGoal from the saved information.
            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);

                Goal goal = new SimpleGoal(
                    name,
                    description,
                    points,
                    isComplete);

                _goals.Add(goal);
            }

            // Re-create an EternalGoal from the saved information.
            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

                Goal goal = new EternalGoal(
                    name,
                    description,
                    points);

                _goals.Add(goal);
            }

            // Re-create a ChecklistGoal from the saved information.
            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);
                int targetCount = int.Parse(parts[4]);
                int currentCount = int.Parse(parts[5]);
                int bonusPoints = int.Parse(parts[6]);

                Goal goal = new ChecklistGoal(
                    name,
                    description,
                    points,
                    targetCount,
                    currentCount,
                    bonusPoints);

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Quest loaded successfully.");
    }

    // Displays the user's score and gamification information.
    public void DisplayScore()
    {
        Console.WriteLine("\n===== YOUR QUEST STATUS =====");

        Console.WriteLine($"Score: {_score}");

        Console.WriteLine($"Level: {GetLevel()}");

        Console.WriteLine($"Title: {GetLevelTitle()}");

        // Display a badge based on the user's score.
        if (_score >= 2500)
        {
            Console.WriteLine("Badge: Quest Master");
        }
        else if (_score >= 1000)
        {
            Console.WriteLine("Badge: Eternal Champion");
        }
        else if (_score >= 500)
        {
            Console.WriteLine("Badge: Faithful Worker");
        }
        else if (_score >= 100)
        {
            Console.WriteLine("Badge: Beginner");
        }
        else
        {
            Console.WriteLine("Badge: Just Getting Started");
        }

        Console.WriteLine("=============================");
    }
}
