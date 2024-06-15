class Breathing: Activity
{
    public Breathing(int duration): base(duration)
    {
        SetActivity("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }
    public Breathing(): base()
    {
        SetActivity("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    public void RunBreathing()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplayAnimation();
        for (int i = 1; i <= GetDuration()/6 ; i++)
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breathe in...");
            CountDown();
            Console.WriteLine();
            Console.Write("Now breathe out...");
            CountDown();
        }
    }

    
}