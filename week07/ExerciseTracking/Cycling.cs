// Cycling.cs
// This class represents a cycling activity.
// It inherits the common information and methods from Activity.

public class Cycling : Activity
{
    // Speed is specific to cycling.
    // It is stored privately to demonstrate encapsulation.
    private double _speed;

    // Constructor for the Cycling class.
    //
    // The date and minutes are passed to the Activity constructor
    // using base(). The speed is stored in this class.
    public Cycling(DateTime date, int minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    // Calculates the distance traveled while cycling.
    //
    // Formula:
    // Distance = (speed * minutes) / 60
    //
    // We divide by 60 because speed is measured in
    // kilometers per hour, while time is in minutes.
    public override double GetDistance()
    {
        return (_speed * GetMinutes()) / 60;
    }

    // Returns the cycling speed.
    //
    // The speed is already stored, so we simply return it.
    public override double GetSpeed()
    {
        return _speed;
    }

    // Calculates the cycling pace in minutes per kilometer.
    //
    // Formula:
    // Pace = 60 / speed
    public override double GetPace()
    {
        return 60 / _speed;
    }

    // Identifies this activity as Cycling.
    public override string GetActivityType()
    {
        return "Cycling";
    }
}
