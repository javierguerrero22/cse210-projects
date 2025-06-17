// Added "NegativeGoal" to introduce goals that penalize the user for bad habits.
// When a user records an event for a NegativeGoal, they lose points instead of gaining them.
// This feature enhances gamification by motivating users to avoid undesirable actions.
// Goals are now categorized into Simple, Eternal, Checklist, and Negative types.
class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"Warning! You lost {_points} points for: {_name}");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        return $"[!] {base.GetDetailsString()} (Penalty: -{_points} points)";
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal,{base.GetStringRepresentation()}";
    }
}