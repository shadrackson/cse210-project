// This class represents a simple goal.
public class SimpleGoal : Goal
{
    // Keeps track of whether the goal is complete.
    private bool _isComplete;

    // Constructor
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    // Record the goal as complete and give points.
    public override int RecordEvent()
    {
        // A simple goal can only be completed once.
        if (!_isComplete)
        {
            _isComplete = true;

            return Points;
        }

        // If it is already complete, give no points.
        return 0;
    }

    // Return whether the goal is complete.
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Create the text that will be displayed on the screen.
    public override string GetDetailsString()
    {
        if (_isComplete)
        {
            return $"[X] {Name} ({Description})";
        }
        else
        {
            return $"[ ] {Name} ({Description})";
        }
    }
}
