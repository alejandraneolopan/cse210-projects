class Activity
{
    string _activityName;
    string _description;
    int _duration;
    public Activity()
    {

    }
    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    public Activity(int duration)
    {
        _duration = duration;
    }
    public string ShowStartMessage()
    {
        return ($"Welcome to the {_activityName} Activity.\n{_description}\n" +
        "How long, in seconds, would you like for your session? ");
    }
    public string ShowEndMessage()
    {
        Console.WriteLine("Well done!");
        DisplayAnimation();
        return($"You have complete another {_duration} seconds of the {_activityName} Activity.");
    }
    public void CountDown()
    {
       for (int j =_duration/6 ; j >= 1; j--)
       {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the number
       }
    }
    public void DisplayAnimation()
    { 
        List<char> animation = new List<char>();
        animation.Add('|');
        animation.Add('/');
        animation.Add('-');
        animation.Add('\\');

        for (int i = 0; i < 10; i++)
        {
            Console.Write(animation[i % 4]);
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the character
            
        }
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public void SetActivity(string activity, string description)
    {
        _activityName = activity;
        _description = description;
    }
}