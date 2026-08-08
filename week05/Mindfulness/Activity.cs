// My VS Code Keeps hanging and crashing
// Activity is the base class (parent class), it contains functionality shared 
// by all three activities

// Class
public class Activity
{
    // These are private member variables.
    // They are kept private to enable encapsulation
    private string _name;
    private string _description;
    private int _duration;
  
    // Constructor for the Activity Class
    // It receives the name and the description of an activity
    // Constructor
    public Activity (string name, string description)
    {
      _name = name;
      _description = description;
      // We don't know the duration yet
      // The user will provide it later
      _duration = 0;
    }
  
    // This method displays the common starting message.
    // All three activities use this method.
    // Method
    public void DisplayStartingMessage()
    {
      // Clears anything that was previously displayed
      Console.Clear();
  
      Console.WriteLine($"Welcome to the {_name}.");
      Console.WriteLine();
  
      // Displays the description of the current activity.
      Console.WriteLine(_description);
      Console.WriteLine();
  
      // Ask the user how long they want the activity to last.
      Console.Write("How long, in seconds, would you like for your session? ");
  
      // Converts the user's input from a text to an integer.
      _duration = int.Parse(Console.ReadLine());
  
      Console.WriteLine();
  
      // Give the user time to prepare.
      Console.WriteLine("Get ready...");
  
      // Shows a spinner for 3 seconds instead of freezing the program with Thread.Sleep().
      ShowSpinner(3);

    }
    // This method displays the common ending message.
    // All three activities will use the same method.
    public void DisplayEndingMessage()
    {
      Console.WriteLine();
      Console.WriteLine("Well done!");
      Console.WriteLine();

      // Tells the user how long the activity lasted
      Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");

      // Pauses with an animation before returning to the main menu.
      ShowSpinner(3);
    }

    // This method creates a simple spinning animation.
    // The number of seconds determines how long the animation runs.
    public void ShowSpinner(int seconds)
    {
      // These characters will appear one after another,
      // Creating the appearance of a spinning object.
      string[] animation = {"|", "/", "-","\\" };

      // Calculates the exact time when the animation should stop.
      DateTime endTime = DateTime.Now.AddSeconds(seconds);

      int i = 0;
      // Continues to display the animation until the time is reached.
      while (DateTime.Now < endTime)
      {
        Console.Write(animation[i]);
      // Waits for 200 milliseconds before changing the character.
        Thread.Sleep(200);

        Console.Write("\b \b"); // \b moves the cursor back one position. The space erases the previous character. The second \b moves the curor back again
        // Moves to the next animation character.
        i++;

        // Start again from the first character when we reach the end.
        if (i >= animation.Length)
        {
          i = 0;
        }
      }
    }

    // This method displays a countdown
    public void ShowCountDown(int seconds)
    {
       for (int i = seconds; i > 0; i--)
       {
         Console.Write(i);
         // Wait one second
         Thread.Sleep(1000);
         Console.Write("\b \b");
       }
    }

    // This method allows the child classes to access the duration
    public int GetDuration()
    {
      return _duration;
    }
}
  
       
  
      
    

    

  
      
