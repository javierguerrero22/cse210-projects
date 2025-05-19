using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string answer){
        
        Entry entry = new Entry();
        entry._date = DateTime.Now.ToShortDateString();
        entry._entryText = answer;
        entry._promptText = prompt;
        _entries.Add(entry);
    }
    public void DisplayAll(){
        foreach ( var entry in _entries){
            entry.Display();
        }
    }
    public void LoadFromFile(string file){
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines){
            Console.WriteLine(line);
        }
        Console.WriteLine();
    }
    public void SaveToFile(string file){
        
        using (StreamWriter outputFile = new StreamWriter(file)){
            foreach (var entry in _entries){
                outputFile.WriteLine($"{entry._date};{entry._promptText};{entry._entryText}");
                // This allows the program to write in .csv files
            }
        }
        Console.WriteLine("File saved correctly \n");
    }
}
