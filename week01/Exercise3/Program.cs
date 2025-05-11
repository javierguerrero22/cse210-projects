using System;

class Program
{
    static void Main(string[] args)
    {
        
        string answer = "yes";

        while (answer.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);
            int guess = -1;
            int count = 0;
            while (guess != number)
            {
                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("lower");
                }
                count++;
            }
            Console.WriteLine("Congratulations!, you guessed it!");
            Console.WriteLine($"You guessed it in {count} attemps!");
            Console.Write("Do you want to play again? ");
            answer = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing, have a nice day");    
    }
}