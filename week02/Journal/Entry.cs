using System;
using Microsoft.VisualBasic;

public class Entry {
    public string _date;
    public string _prompt;
    public string _response;

    // Dates
    public void GenerateDate() {
        DateTime currentDate = DateTime.Now;
        _date = currentDate.ToShortDateString();
    }

    // Prompt
    public void GeneratePrompt() {
        List<string> prompts = new List<string>() {
            "Who was the most interesting person I interacted with today?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What did you learned fromt the Scriptures today?",
            "How did you felt when you prayed today?",
        };

        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        _prompt = prompts[randomIndex];
        Console.WriteLine(_prompt);
    }

    public void Response() {
        Console.Write("- ");
        _response = Console.ReadLine();
    }
}