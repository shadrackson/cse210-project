// My VS Code Keeps hanging and crashing
// This class inherits from Activity
// It therefore gets access to the methods and data provided by the activity class
// Class

public class BreathingActivity : Activity
{
   // Constructor for BreathingActivity.
   public BreathingActivity()
      // base(...) calls the constructor of the parent Activity class
      : base(
      
              "Breathing Activity",
              "This activity will help you relax by wallking you through breathing in and out slowly. Clear your mind and focus on breathing."     
      )
      {
      }
      // This method runs the actual breathing activity.
      public void Run()
      {
        // Display the common starting message.
        // It also asks the user for the duration
        DisplayStartingMessage();

        // Keeps track of how many seconds have passed.
        int elapsedTime = 0;
        // Each breathing phase will last 4 seconds
        int breathingTime = 4;
        // Continue until we reach the duration chosen by the user.
        while (elapsedTime < GetDuration())
        {
          // Tells the user to breathe in.
          Console.WriteLine();
          Console.Write("Breathe in...");
          // Displays a countdown while they breathe in.
          ShowCountDown(breathingTime);
          Console.WriteLine();

          // Add the breathing time to the total elapsed time.
          elapsedTime += breathingTime;
          // Checks whether the user's requested duration has already been reached
          if (elapsedTime >= GetDuration())
          {
            break;
          }
          // Tell the user to breathe out.
          Console.Write("Breathe out...");
          // Displays another countdown
          ShowCountDown(breathingTime);

          Console.WriteLine();
          // Add the breathing out time
          elapsedTime += breathingTime;

        }
        // Display the common ending message.
        DisplayEndingMessage();
      }
}  
        
