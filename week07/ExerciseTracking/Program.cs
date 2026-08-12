using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        // Create a Running activity.
        //
        // Date: November 3, 2026
        // Duration: 30 minutes
        // Distance: 4.8 kilometers
        Running running = new Running(
            new DateTime(2026, 11, 3),
            30,
            4.8
        );

        // Create a Cycling activity.
        //
        // Date: November 4, 2026
        // Duration: 45 minutes
        // Speed: 12 kilometers per hour
        Cycling cycling = new Cycling(
            new DateTime(2026, 11, 4),
            45,
            12
        );

        // Create a Swimming activity.
        //
        // Date: November 5, 2026
        // Duration: 40 minutes
        // Number of laps: 40
        Swimming swimming = new Swimming(
            new DateTime(2026, 11, 5),
            40,
            40
        );

        // Create a list that can hold any object
        // that is an Activity.
        //
        // Running, Cycling, and Swimming all inherit
        // from Activity, so they can all be stored
        // in this same list.
        List<Activity> activities = new List<Activity>();

        // Add each activity to the same list.
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        // Go through each activity in the list.
        //
        // The variable is declared as Activity, but
        // polymorphism allows C# to use the correct
        // overridden methods belonging to the actual object.
        foreach (Activity activity in activities)
        {
            // GetSummary() is inherited from Activity.
            //
            // Inside GetSummary(), the program calls
            // GetDistance(), GetSpeed(), and GetPace().
            //
            // Because those methods are overridden,
            // the correct version for Running, Cycling,
            // or Swimming is automatically used.
            Console.WriteLine(activity.GetSummary());
        }
        
    }
}
