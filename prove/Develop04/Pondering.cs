class Pondering: Activity
{
    List<string> _prompts;
    string _welcomeMessage;
    string _FILE_PROMPTS;

    public Pondering(string activityName, string description, int duration, string msg, string filename): base(activityName, description, duration)
    {
        _welcomeMessage = msg;
        _prompts = new List<string>();
        _FILE_PROMPTS = filename;
    }

    public void PopulatePrompts()
    {
        string[] lines = System.IO.File.ReadAllLines(_FILE_PROMPTS);
        foreach (string item in lines)
        {
            _prompts.Add(item);
        }
    }
    public void Run()
    {
        Console.Clear();
        Console.WriteLine ("Get ready...");
        DisplayAnimation();
        Console.WriteLine(_welcomeMessage);
        string prompt = GetRandomPrompt();
        Console.WriteLine("---  " + prompt + " ---");
    }
    public string GetRandomPrompt()
    {
        Random ran = new Random();
        string prompt;
        prompt = "";
        if(_prompts.Count() > 0)
        {
            int index = ran.Next(0, _prompts.Count() - 1);
            if (index >= 0)
            {
                prompt = _prompts[index];
            }
            
            _prompts.RemoveAt(index);
        }
        
        return prompt;
    }
}