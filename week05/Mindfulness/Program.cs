using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Listing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Breathing");
            Console.WriteLine("4. Exit");

            Console.Write("\nEnter your choice: ");
            choice = Console.ReadLine();

            Activity activity = null;

            if (choice == "1") activity = new ListingActivity();
            if (choice == "2") activity = new ReflectionActivity();
            if (choice == "3") activity = new BreathingActivity();

            if (activity != null)
            {
                activity.StartMessage();

                if (choice == "1") ((ListingActivity)activity).StartActivity();
                else if (choice == "2") ((ReflectionActivity)activity).StartActivity();
                else if (choice == "3") ((BreathingActivity)activity).StartActivity();

                activity.EndMessage();

                Console.WriteLine("Press ENTER key to continue...");
                Console.ReadLine();
            }
        }
    }
}