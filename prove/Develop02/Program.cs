using System;

class Program
{
    static void Main(string[] args)
    {
            Journal myJournal = new Journal(); 
 
            string fileName = "myJournal.txt"; 
            string description, location, prompt;
            
 
            while (true)
            {
                Console.WriteLine("1. Write new entry");
                Console.WriteLine("2. Display journal");
                Console.WriteLine("3. Save journal");
                Console.WriteLine("4. Load journal");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
 
                int option = Convert.ToInt32(Console.ReadLine());
 
                switch (option)
                {
                    case 1:
                        prompt = myJournal.getRandomPrompt();
                        Console.WriteLine(prompt);
                        description = Console.ReadLine();
                        Console.Write("Location: ");
                        location = Console.ReadLine();
                        myJournal.AddEntry(prompt, description, location);
                        break;
                    case 2:
                        myJournal.Display();
                        break;
                    case 3:
                        myJournal.Save(fileName);
                        break;
                    case 4:
                        myJournal.Load(fileName);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
 
            }
        }

}