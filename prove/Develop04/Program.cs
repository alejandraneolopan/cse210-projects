using System;

class Program
{
    static void Main(string[] args)
    {
        char choice;
        int duration = 0;
        Console.Clear();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start Breathing Activity");
        Console.WriteLine("  2. Start Reflecting Activity");
        Console.WriteLine("  3. Start Listing Activity");
        Console.WriteLine("  4. Quit");
        Console.Write("Select a choice from the menu: ");
        choice = Console.ReadLine()[0];
        switch (choice)
        {
            case '1':
                Breathing breath = new Breathing();
                Console.WriteLine(breath.ShowStartMessage());
                duration = int.Parse(Console.ReadLine());
                breath.SetDuration(duration);
                breath.RunBreathing();
                Console.WriteLine(breath.ShowEndMessage());
                break;
            case '2':
                Reflecting reflecting = new Reflecting();
                Console.WriteLine(reflecting.ShowStartMessage());
                duration = int.Parse(Console.ReadLine());
                reflecting.SetDuration(duration);
                reflecting.RunReflecting();
                Console.WriteLine(reflecting.ShowEndMessage());
                break;
            case '3':
                Listing list = new Listing();
                Console.WriteLine(list.ShowStartMessage());
                duration = int.Parse(Console.ReadLine());
                list.SetDuration(duration);
                list.RunListing();
                Console.WriteLine(list.ShowEndMessage());
                break;

        }
        
    }
}