using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Javier Guerrero", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        MathAssignment mathAssignment1 = new MathAssignment("Javier Guerrero", "Multiplication", "47", "20-25");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        WritingAssignment writingAssignment1 = new WritingAssignment("Javier Guerrero", "History", "The fell of the Empire");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}