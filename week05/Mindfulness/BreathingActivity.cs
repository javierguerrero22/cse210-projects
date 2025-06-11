class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", new List<string>()) { }

    public void StartActivity()
    {
        DateTime endtime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endtime)
        {
            Console.WriteLine("Inhale...");
            PauseTimer(4);
            Console.WriteLine("Exhale...");
            PauseTimer(4);
        }
    }
}
