class Reflecting: Pondering
{
    string _FILE_QUESTIONS = "ReflectionQuestions.txt";
    List<string> _questions;

        
    public Reflecting(): base("Reflecting","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0,"Consider the following prompt:", "ReflectionPrompts.txt")
    {
        
        PopulatePrompts();
        _questions = new List<string>();
        PopulateQuestions(_FILE_QUESTIONS);
    }
    public void RunReflecting()
    {
        base.Run();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        CountDown();
        Console.Clear();
        string question;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {  
            question = GetRandomQuestion();
            Console.WriteLine("> " + question);
            DisplayAnimation();
            Console.ReadLine();
            currentTime = DateTime.Now;
        }

    }

    public string GetRandomQuestion()
    {
        Random ran = new Random();
        string question = "";
        int index = ran.Next(0, _questions.Count() - 1);
        if (index >= 0)
        {
            question = _questions[index];
        }
            
        _questions.RemoveAt(index);
        return question;
    }

    public void PopulateQuestions(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string item in lines)
        {
            _questions.Add(item);
        }
        
    }
}