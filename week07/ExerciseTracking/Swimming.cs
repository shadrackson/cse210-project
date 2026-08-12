// Swimming.cs
// This class represents a swimming activity.
// It inherits common information from Activity.

public class Swimming : Activity
{
    // Number of laps completed in the swimming pool.
    // Each lap is 50 meters according to the assignment.
    private int _laps;

    // Constructor for the Swimming class.
    //
    // Date and minutes are handled by the Activity class.
    // Laps are specific to Swimming.
    public Swimming(DateTime date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    // Calculates the swimming distance in kilometers.
    //
    // Each lap is 50 meters.
    //
    // Formula:
    // Distance = laps * 50 / 1000
    //
    // We divide by 1000 to convert meters to kilometers.
    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0;
    }

    // Calculates swimming speed in kilometers per hour.
    //
    // Formula:
    // Speed = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    // Calculates swimming pace in minutes per kilometer.
    //
    // Formula:
    // Pace = minutes / distance
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }

    // Identifies this activity as Swimming.
    public override string GetActivityType()
    {
        return "Swimming";
    }
}
