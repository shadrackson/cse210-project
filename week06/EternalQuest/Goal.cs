 // This is the base class for all types of goals.
// It contains information and behavior that all goals share.
public abstract class Goal
{
    // Private variables demonstrate encapsulation.
    // These variables can only be accessed directly inside this class.
    private string _name;
    private string _description;
    private int _points;

    // Constructor used to create a goal.
    // The information is provided when a goal is created.
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // These properties allow other classes to read
    // the information stored in the private variables.
    public string Name
    {
        get { return _name; }
    }

    public string Description
    {
        get { return _description; }
    }

    public int Points
    {
        get { return _points; }
    }

    // Determines whether the goal has been completed.
    // Each type of goal will implement this differently.
    public abstract bool IsComplete();

    // Records an event and returns the number of points earned.
    // Each type of goal will override this method.
    public abstract int RecordEvent();

    // Creates the text that will be displayed when
    // the user chooses to see their goals.
    public abstract string GetDisplayString();

    // Converts the goal into text that can be saved to a file.
    public abstract string GetSaveString();
} 

