using System;
// Added "NegativeGoal" to introduce goals that penalize the user for bad habits.
// When a user records an event for a NegativeGoal, they lose points instead of gaining them.
// This feature enhances gamification by motivating users to avoid undesirable actions.
// Goals are now categorized into Simple, Eternal, Checklist, and Negative types.
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}