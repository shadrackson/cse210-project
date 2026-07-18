
// Exceeding Requirements:
// This program calculates and displays the word count for each journal
// entry. The word count is shown after an entry is written and whenever
// journal entries are displayed.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();
        
        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);

                Console.Write("> ");
                string response = Console.ReadLine();


                Entry entry = new Entry();

                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = response;


                journal._entries.Add(entry);
                Console.WriteLine($"Entries in journal1: {journal._entries.Count}");
                Console.WriteLine($"Word Count: {entry.GetWordCount()} words.");
            }

              else if (choice == "2")
            {
                journal.Display();
            }


            else if (choice == "3")
            {
                Console.Write("Enter filename to load: ");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded successfully.");
            }


            else if (choice == "4")
            {
                Console.Write("Enter filename to save: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);

                Console.WriteLine("Journal saved successfully.");
            }


            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }


            else
            {
                Console.WriteLine("Invalid choice.");
            }
            
        }
    }
}
