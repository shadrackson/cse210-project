// Added an animation icon as part of creativity
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
         // Keep showing the menu until the user chooses Quit.
        while (true)
        {
            Console.Clear();

            // Display the program title.
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();

            // Display the available choices.
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine();

            // Ask the user to choose an activity.
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            // If the user chooses 1, start the breathing activity.
            if (choice == "1")
            {
                // Create a BreathingActivity object.
                BreathingActivity activity = new BreathingActivity();

                // Run the activity.
                activity.Run();
            }

            // If the user chooses 2, start the reflection activity.
            else if (choice == "2")
            {
                // Create a ReflectionActivity object.
                ReflectionActivity activity = new ReflectionActivity();

                // Run the activity.
                activity.Run();
            }

            // If the user chooses 3, start the listing activity.
            else if (choice == "3")
            {
                // Create a ListingActivity object.
                ListingActivity activity = new ListingActivity();

                // Run the activity.
                activity.Run();
            }

            // If the user chooses 4, leave the loop and end the program.
            else if (choice == "4")
            {
                break;
            }

            // Handle an invalid menu choice.
            else
            {
                Console.WriteLine("Invalid choice.");

                // Give the user a short pause before showing the menu again.
                Thread.Sleep(1500);
            }
        }
        
    }
}
