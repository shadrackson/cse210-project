// My VS code keeos hanging.

// ReflectionActivity inherits from Activity.
public class ReflectionActivity : Activity
{
    // A list containing the reflection prompts.
    // It is private because the ReflectionActivity class
    // should control how these prompts are used.
    private List<string> _prompts;

    // A list containing the reflection questions.
    private List<string> _questions;

    // Random object used to select random prompts and questions.
    private Random _random;

    // Constructor for ReflectionActivity.
    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        )
    {
        // Creates a Random object.
        _random = new Random();

        // Creates the list of possible reflection prompts.
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // Creates the list of questions the user can reflect on.
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // This method runs the reflection activity.
    public void Run()
    {
        // Display the common starting message.
        // The user will also enter the duration here.
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        // Get a random prompt from our prompt list.
        string prompt = GetRandomPrompt();

        // Display the selected prompt.
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

        Console.WriteLine(
            "When you have something in mind, press Enter to continue."
        );

        // Wait for the user to press Enter.
        Console.ReadLine();

        // Calculate when the activity should finish.
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        // Continue asking questions until the duration is reached.
        while (DateTime.Now < endTime)
        {
            // Select a random question.
            string question = GetRandomQuestion();

            Console.WriteLine();

            // Display the question.
            Console.WriteLine($"Question: {question}");

            // Give the user time to think about the question.
            // The spinner provides visual feedback during the pause.
            ShowSpinner(5);
        }

        // Display the common ending message.
        DisplayEndingMessage();
    }

    // This method selects and returns a random prompt.
    private string GetRandomPrompt()
    {
        // Random.Next returns a number between 0 and
        // _prompts.Count - 1.
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }

    // This method selects and returns a random question.
    private string GetRandomQuestion()
    {
        int index = _random.Next(_questions.Count);

        return _questions[index];
    }
}
