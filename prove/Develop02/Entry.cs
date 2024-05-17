public class Entry
{
   public DateTime _entryDate;
   public string _entryPrompt; 
   public string _entryDescription;

    public void Display()
    {
        Console.WriteLine($"{_entryDate} - {_entryPrompt} ");
        Console.WriteLine($"{_entryDescription} ");
        Console.WriteLine();
    }
}