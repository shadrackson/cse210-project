

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine("Entry added successfully!");
        Console.WriteLine($"Word Count: {GetWordCount()} words.");
    }

    public int GetWordCount()
    {
        string[] words = _entryText.Split(' ');
        return words.Length;
    }

    
    
}