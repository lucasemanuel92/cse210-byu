using System;

public class Journal
{
    // Creating an entry list
    public List<Entry> _entries = new List<Entry>();

    // What needs to be in the list 9date, prompt and response
    public void NewEntry()
    {
        Entry userEntry = new Entry();
        userEntry.GenerateDate();
        userEntry.GeneratePrompt();
        userEntry.Response();
        _entries.Add(userEntry);
    }

    // What will be shown in the display 
    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"{entry._response}");
            Console.WriteLine("");
        }
    }

    // Load the saved entries 
    public void Load(string filename)
    {
        if (filename.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"{response}");
                Console.WriteLine();
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                String journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }
    // Save the entries as a .csv file (VERY TRICKY)
    public void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true))
        {
            if (filename.EndsWith(".csv"))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
                }
            }
            else
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"Date:{entry._date},{entry._prompt},{entry._response}");
                    outputFile.WriteLine($"Prompt:{entry._prompt}");
                    outputFile.WriteLine($"{entry._response}");
                    outputFile.WriteLine();
                }
            }
        }
    }
}
