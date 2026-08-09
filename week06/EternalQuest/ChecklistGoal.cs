// ChecklistGoal inherits from the Goal base class.
// This is another example of inheritance.
public class ChecklistGoal : Goal
{
    // The number of times the user needs to complete the goal.
    private int _targetCount;

    // The number of times the user has completed the goal so far.
    private int _currentCount;

    // Extra points awarded when the target is reached.
    private int _bonusPoints;

    // Constructor used to create a new checklist goal.
    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetCount,
        int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    // This constructor is used when loading a saved checklist goal.
    // It allows us to restore the previous progress.
    public ChecklistGoal(
        string name,
        string description,
        int points,
        int targetCount,
        int currentCount,
        int bonusPoints)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = currentCount;
        _bonusPoints = bonusPoints;
    }

    // The checklist is complete when the current count
    // reaches the target count.
    public override bool IsComplete()
    {
        return _currentCount >= _targetCount;
    }

    // Records one completion of the checklist goal.
    public override int RecordEvent()
    {
        // Do not allow additional completions after
        // the checklist has already been completed.
        if (IsComplete())
        {
            return 0;
        }

        // Increase the number of completed events by one.
        _currentCount++;

        // Start with the normal points for completing the goal.
        int earnedPoints = Points;

        // If this completion reaches the target,
        // give the user the bonus points as well.
        if (_currentCount == _targetCount)
        {
            earnedPoints += _bonusPoints;
        }

        return earnedPoints;
    }

    // Displays the checklist goal and its progress.
    public override string GetDisplayString()
    {
        // Show [X] when the target has been reached.
        // Otherwise show [ ].
        string checkbox = IsComplete() ? "[X]" : "[ ]";

        return $"{checkbox} {Name} ({Description}) " +
               $"-- Completed {_currentCount}/{_targetCount} times";
    }

    // Converts the checklist goal into text for saving.
    public override string GetSaveString()
    {
        return $"ChecklistGoal|{Name}|{Description}|{Points}|" +
               $"{_targetCount}|{_currentCount}|{_bonusPoints}";
    }
}
