using System.IO; 
public class Journal
{
    List<Entry> _entries = new List<Entry>();
    List<string> _prompts = ["Who was the most interesting person I interacted with today?",
                        "What was the best part of my day?",
                        "How did I see the hand of the Lord in my life today?",
                        "What was the strongest emotion I felt today?",
                        "If I had one thing I could do over today, what would it be?"];
    string _key = "b14ca5898a4e4133bbce2ea2315a1916";                        

    public void AddEntry(string prompt, string description)
    {
        Entry entry = new Entry();
        entry._entryPrompt = prompt;
        entry._entryDate = DateTime.Now;
        entry._entryDescription = description;
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
        string decryptedLine;
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {   Entry newEntry = new Entry();

            //Decrypt before split
            decryptedLine = AesOperation.DecryptString(_key, line);

            string[] parts = decryptedLine.Split(" - ");
            newEntry._entryDate = DateTime.Parse(parts[0]);
            newEntry._entryPrompt = parts[1];
            newEntry._entryDescription = parts[2];
            _entries.Add(newEntry);
        }
    }

    public void Save(string fileName)
    {
        string encryptedLine;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        foreach (Entry entry in _entries)
        {   //Encrypt first before saving the line
            encryptedLine = AesOperation.EncryptString(_key, entry._entryDate + " - " + entry._entryPrompt + " - " + entry._entryDescription);
            outputFile.WriteLine(encryptedLine);
        }
        
    
    }

    public string getRandomPrompt()
    {
         Random random = new Random();
        int index = random.Next(0,_prompts.Count);
        return(_prompts[index]);
    }
}