using System.IO; 
public class Journal
{
    List<Entry> _entries = new List<Entry>();
    List<string> _prompts = ["Who was the most interesting person I interacted with today?",
                        "What was the best part of my day?",
                        "How did I see the hand of the Lord in my life today?",
                        "What was the strongest emotion I felt today?",
                        "If I had one thing I could do over today, what would it be?"];

    public void AddEntry(string prompt, string description, string location)
    {
        Entry entry = new Entry();
        entry._entryPrompt = prompt;
        entry._entryDate = DateTime.Now;
        entry._entryDescription = description;
        entry._location = location;
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Load(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {   Entry newEntry = new Entry();
            string[] parts = line.Split(" - ");
            newEntry._entryDate = DateTime.Parse(parts[0]);
            newEntry._entryPrompt = parts[1];
            newEntry._entryDescription = parts[2];
            newEntry._location = parts[3];
            _entries.Add(newEntry);
        }
    }

    public void Save(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        foreach (Entry entry in _entries)
        {
            outputFile.WriteLine(entry._entryDate + " - " + entry._entryPrompt + " - " + entry._entryDescription + " - " + entry._location);
        }
      
    
    }

    public string getRandomPrompt()
    {
         Random random = new Random();
        int index = random.Next(0,_prompts.Count);
        return(_prompts[index]);
    }
}