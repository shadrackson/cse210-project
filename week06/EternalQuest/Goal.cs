// This is the base class for all goals.
public abstract class Goal
{
    // Private variables helps us practice encapsulation.
    private string _name;
    private string _description;
    private int _points;

    // Constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // Properties allow other classes to read the information.
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

    // Each type of goal will implement these differently.
    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetDetailsString();
}
