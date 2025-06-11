class ListingActivity : Activity
{
    private List<string> _responsesList;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", new List<string> { "Who are the people you appreciate?", "What are your personal strengths?", "Who have you helped this week?", "When have you felt peace this month?", "Who are some of your personal heroes?" }) { }

    public void StartActivity()
    {
        Console.WriteLine($"\n{GetRandomPrompt()}");
        Console.WriteLine("Think about it for a few seconds");
        PauseTimer(5);
        Console.WriteLine("\nNow start listing:");

        _responsesList = new List<string>();
        DateTime endtime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endtime)
        {
            Console.Write("> ");
            _responsesList.Add(Console.ReadLine());
        }
        Console.WriteLine($"You have entered {_responsesList.Count} items");
    }
}