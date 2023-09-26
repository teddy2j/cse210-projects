using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator._prompts.Add("Who was the most interesting person I interacted with today? ");
        promptGenerator._prompts.Add("What was the best part of my day? ");
        promptGenerator._prompts.Add("How did I see the hand of the Lord in my life today? ");
        promptGenerator._prompts.Add("What was the strongest emotion I felt today? ");
        promptGenerator._prompts.Add("If I had one thing I could do over today, what would it be? ");




        string response = "100";
        while (response != "5")
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("Welcome to the Journal Program:");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            response = Console.ReadLine();

            if (response == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.Write($"{prompt}");
                Entry newEntry = new Entry();
                newEntry._date = "september 25";
                newEntry._promptText= prompt;
                newEntry._entryText = Console.ReadLine();
                journal.AddEntry(newEntry);
            }

            if (response == "2")
            {
                journal.DisplayAll();
            }

            if (response == "3")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            if (response == "4")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }


        }

    }
}