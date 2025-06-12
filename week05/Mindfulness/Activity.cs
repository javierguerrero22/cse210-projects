// This program enhances the Mindfulness Project by adding personalized encouragement
// based on the user's selected duration (see Activity.StartMessage() lines 49-50).
// Longer mindfulness sessions receive extra motivation to keep going!
//This is ideal and motivating for them to continue using this program and keep working hard and moving forward.
class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected Random random = new Random();
    protected List<string> _prompts;

    public Activity(string name, string description, List<string> prompts)
    {
        _name = name;
        _description = description;
        _prompts = prompts;
    }

    public void PauseTimer(int seconds)
    {
        string[] animationStrings = { "|", "/", "-", "\\" };

        Console.Write($"Waiting... ");
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
            Console.Write("\b \b");
        }
        Console.Write("\r               ");
        Console.WriteLine("\r\n");
    }

    public void StartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting the activity: {_name}");
        Console.WriteLine(_description);

        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        if (_duration > 30) Console.WriteLine("You're dedicating a solid amount of time to mindfulness—keep it up!");//Added
        else Console.WriteLine("Even small moments of mindfulness matter—nice work!");//Added

        Console.WriteLine("\nGet ready to start...");
        PauseTimer(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("Good job!");
        PauseTimer(2);
        Console.WriteLine($"You have completed the activity '{_name}' in {_duration} seconds");
        PauseTimer(3);
    }

    public string GetRandomPrompt()
    {
        return _prompts[random.Next(_prompts.Count)];
    }

    // public void Start()
    // {
    //     StartMessage();
    //     StartActivity();
    //     EndMessage();
    // }
    // public void StartActivity(){}
}