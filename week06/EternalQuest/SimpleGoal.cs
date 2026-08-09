 // SimpleGoal inherits from the Goal base class.
// This is an example of inheritance.
public class SimpleGoal : Goal
{
    // Keeps track of whether the goal has been completed.
    private bool _isComplete;

    // Constructor for creating a new simple goal.
    // The base constructor receives the shared goal information.
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        // A new simple goal starts as incomplete.
        _isComplete = false;
    }

    // This constructor is used when loading a saved goal.
    // It allows us to restore the previous completion status.
    public SimpleGoal(
        string name,
        string description,
        int points,
        bool isComplete)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // A simple goal is complete when the user records it.
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Records the goal and gives the user points.
    public override int RecordEvent()
    {
        // A simple goal can only give points once.
        if (!_isComplete)
        {
            _isComplete = true;

            // Return the points earned for completing the goal.
            return Points;
        }

        // If the goal has already been completed,
        // the user does not receive more points.
        return 0;
    }

    // Creates the text that will be shown in the goal list.
    public override string GetDisplayString()
    {
        // Display [X] when completed and [ ] when incomplete.
        string checkbox = _isComplete ? "[X]" : "[ ]";

        return $"{checkbox} {Name} ({Description})";
    }

    // Converts the goal into text that can be stored in the save file.
    public override string GetSaveString()
    {
        return $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
    }
}
