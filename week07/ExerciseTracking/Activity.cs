// Activity.cs
// This is the base class for all exercise activities.
// Running, Cycling, and Swimming will inherit from this class.

public abstract class Activity
{
    // These private member variables demonstrate encapsulation.
    // They store information that is common to every activity.
    private DateTime _date;
    private int _minutes;

    // Constructor used to create an Activity object.
    // The date and duration are passed in when the object is created.
    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Returns the date of the activity.
    public DateTime GetDate()
    {
        return _date;
    }

    // Returns the duration of the activity in minutes.
    public int GetMinutes()
    {
        return _minutes;
    }

    // Abstract methods:
    // These methods are declared here but are not implemented.
    //
    // Every derived class MUST provide its own implementation.
    // This is abstraction and allows us to use polymorphism.

    // Each activity calculates distance differently.
    public abstract double GetDistance();

    // Each activity calculates speed differently.
    public abstract double GetSpeed();

    // Each activity calculates pace differently.
    public abstract double GetPace();

    // This method will be overridden by the derived classes
    // to identify the type of activity.
    public abstract string GetActivityType();

    // Creates a summary of the activity.
    // We do not calculate distance, speed, or pace here.
    // Instead, we call the methods above.
    //
    // Because those methods are abstract and overridden by the
    // derived classes, the correct calculation will happen
    // automatically. This is polymorphism.
    public virtual string GetSummary()
    {
        return $"{GetDate():dd MMM yyyy} {GetActivityType()} ({GetMinutes()} min): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed: {GetSpeed():0.0} kph, " +
               $"Pace: {GetPace():0.00} min per km";
    }
}
