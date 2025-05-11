using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Your grade percentage: ");
        string Percentage = Console.ReadLine();
        int number = int.Parse(Percentage);
        string letter = "";
        int lastNumber = number % 10;
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (lastNumber >= 7)
        {
            Console.WriteLine($"Your grade note is: \"{letter}+\"");
        }
        else if (lastNumber <= 3)
        {
            Console.WriteLine($"Your grade note is: \"{letter}-\"");
        }
        else
        {
            Console.WriteLine($"Your grade note is: \"{letter}\"");
        }
        
        if (number >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time");
        }
    }
}