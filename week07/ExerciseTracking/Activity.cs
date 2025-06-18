abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return ($"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({GetMinutes()} min): Distance {GetDistance():0.0} km, Speed {GetSpeed():0.0} Kph, Pace {GetPace():0.0} min per km.");
    }
}