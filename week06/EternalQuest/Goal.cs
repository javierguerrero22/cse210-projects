using System.IO; 


abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        return $"{_name}: {_description} ({_points} pts)";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_name},{_description},{_points}";
    }

    public virtual int GetPoints()
    {
        return _points;
    }
    public string GetName()
    {
        return _name;
    }
}



