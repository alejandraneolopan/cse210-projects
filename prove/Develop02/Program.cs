using System;
using  System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal(); 
        string description, prompt, filename;
        string todaysfile = "myjournal" + DateTime.Now.ToString("MM-dd-yyyy") + ".txt";
        char choice;

        //Initialize file if this exist
        if (File.Exists(todaysfile))
        {
            myJournal.Load(todaysfile);
        }

        Console.WriteLine("***** Welcome to your Journal *****");
        Console.WriteLine("Today's entries will be saved at Today's date file");
        do
        {
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Load and Display an specific Journal file");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
 
            int option = Convert.ToInt32(Console.ReadLine());
 
            if (option == 1)//Add a new entry
            {
                prompt = myJournal.getRandomPrompt();
                Console.WriteLine();
                Console.WriteLine(prompt);
                description = Console.ReadLine();
                myJournal.AddEntry(prompt, description);
                Console.Write("Save journal? (Y/N) [Y]: ");
                choice = Char.Parse(Console.ReadLine());
                
                if (choice!='N')
                {
                    myJournal.Save(todaysfile);
                    Console.WriteLine("Entry saved.");
                }
            }    
            else if (option == 2)//Display Journal file
            {
                Console.Write("Enter filename: ");
                filename = Console.ReadLine();
                if (File.Exists(filename))
                {
                    if (filename != todaysfile)
                    {
                        myJournal.Load(filename);
                    }
                    
                    myJournal.Display();
                    
                }
                
                else
                {
                    Console.WriteLine("Invalid file.");
                }
            }
            
            Console.Write("Do you want to continue? (Y/N) [Y]: ");
            choice = Char.Parse(Console.ReadLine());
        } while (choice != 'N');
        Console.WriteLine("Thanks for using the app.");
            
    }

}