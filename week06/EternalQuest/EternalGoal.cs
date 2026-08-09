// EternalGoal inherits from the Goal base class.
// This demonstrates inheritance.
public class EternalGoal : Goal
{
    // Constructor used to create an eternal goal.
    // The shared information is passed to the Goal constructor.
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    // An eternal goal is never considered complete.
    // The user can continue recording it indefinitely.
    public override bool IsComplete()
    {
        return false;
    }

    // Records an event and gives the user points.
    // Unlike SimpleGoal, this can happen repeatedly.
    public override int RecordEvent()
    {
        return Points;
    }

    // Creates the text that will be displayed in the goal list.
    public override string GetDisplayString()
    {
        // An eternal goal is never completed,
        // so it always displays an empty checkbox.
        return $"[ ] {Name} ({Description})";
    }

    // Converts the goal into text that can be saved to a file.
    public override string GetSaveString()
    {
        return $"EternalGoal|{Name}|{Description}|{Points}";
    }
}
