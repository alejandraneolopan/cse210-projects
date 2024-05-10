public class Entry
{
   public DateTime _entryDate;
   public string _entryPrompt; 
   public string _entryDescription;
   public string _location;

    public void Display()
    {
        Console.WriteLine($"Date: {_entryDate} ");
        Console.WriteLine($"Prompt: {_entryPrompt} ");
        Console.WriteLine($"{_entryDescription} ");
        Console.WriteLine($"Location: {_location} ");
        Console.WriteLine();
    }
}