class Listing: Pondering
{
    List<string> list;
    public Listing(): base("Listing","Thisactivity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, "List as many responses you can to the following prompt:", "ListingPrompts.txt")
    {
        list = new List<string>();
        PopulatePrompts();
    }

    public void RunListing()
    {
        string response;
        base.Run();
        Console.Write("You may begin in: ");
        CountDown();
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {    
                Console.Write(" > ");
                response = Console.ReadLine();
                list.Add(response);
                currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {list.Count} items.");
    }

}