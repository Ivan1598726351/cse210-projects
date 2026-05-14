using System;

public class Journal
{
    
    public List <Entry> _entries = new List<Entry>();


    public void Display()
    {
        
        foreach (Entry entry in _entries)
        {
            
            entry.Display();
        }
    }

    public void SavetoFile()
    {
        Console.WriteLine("Saving to file...");
        string filename = "Journal.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
                outputFile.WriteLine();
            }
        }

    }

    public void ReadFromFile()
    {
        Console.WriteLine("Reading from file...");
        string filename= "Journal.txt";
        string[] lines =System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }



}