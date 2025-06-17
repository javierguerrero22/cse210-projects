class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete) 
    : base(name, description, points)
    {
    _isComplete = isComplete;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {base.GetDetailsString()}";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{base.GetStringRepresentation()},{_isComplete}";
    }
}