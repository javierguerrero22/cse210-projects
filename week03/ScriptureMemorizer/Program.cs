// I added a difficulty in the number of hiden words, when you press ENTER one more word will be hiden gradually.
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress ENTER to hide more words or write QUIT to exit\n");
        int number = 0;//Added

        while (!scripture.IsCompletelyHidden())
        {
            string answer = Console.ReadLine();
            if (answer.ToLower() == "quit")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
            number++; //Added
            scripture.HideRandomWords(number);//Changed
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress ENTER to hide more words or write QUIT to exit\n");
        }
    }
}