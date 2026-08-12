// Running.cs
// This class represents a running activity.
// It inherits the common information and behavior from Activity.

public class Running : Activity
{
    // Distance is specific to running.
    // It is private to demonstrate encapsulation.
    private double _distance;

    // Constructor for the Running class.
    //
    // The base() part sends the date and minutes
    // to the constructor of the Activity class.
    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // Returns the distance covered during the run.
    //
    // This overrides the abstract GetDistance() method
    // from the Activity base class.
    public override double GetDistance()
    {
        return _distance;
    }

    // Calculates the running speed in kilometers per hour.
    //
    // Formula:
    // Speed = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    // Calculates the running pace in minutes per kilometer.
    //
    // Formula:
    // Pace = minutes / distance
    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }

    // Identifies this activity as Running.
    //
    // The GetSummary() method in Activity uses this method
    // when creating the summary.
    public override string GetActivityType()
    {
        return "Running";
    }
}
