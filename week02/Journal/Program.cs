// I've Improved the process of saving and loading to save as a .csv file that could be opened in Excel
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();
        PromptsGenerator generator = new PromptsGenerator();
        string choice = "0";
        while (choice != "5"){
            
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();
            Console.WriteLine();
            if (choice == "1"){
                string prompt = generator.GetRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                string answer = Console.ReadLine();
                journal.AddEntry(prompt, answer);
                Console.WriteLine();
            }
            else if (choice == "2"){
                journal.DisplayAll();
                // entry._promptText =             
            }
            else if (choice == "3"){
                Console.Write("Which file do you want to load to?: ");
                string load = Console.ReadLine();
                Console.WriteLine("File loaded: \n");
                journal.LoadFromFile(load);
            }
            else if (choice == "4"){
                Console.Write("Which file do you want to save to?: ");
                string save = Console.ReadLine();
                journal.SaveToFile(save);
            }
            else if (choice == "5"){
                Console.WriteLine("See you later!");
            }
        }
    }
}