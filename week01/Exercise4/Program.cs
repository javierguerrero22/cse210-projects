using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (enter 0 to exit): ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The number sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The numbers average is: {average}");
        
        int max = -999999999;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }
}