using System;

class Program
{
    static void Main(string[] args)
    {

        List<Activity> activities = new List<Activity>()
        {
            new Running(DateTime.Now, 30, 10),
            new Cycling(DateTime.Now, 25, 25),
            new Swimming(DateTime.Now, 20, 60)
        };
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}