class Checklist: Goal
{
    int _bonus;
    int _times;
    int _timesComplete;
    public Checklist(string name, string description, int points, int bonus, int times): base(name, description, points)
    {
        _bonus = bonus;
        _times = times;
        _timesComplete = 0;
    }
    public override string GetDescription()
    {
       return base.GetDescription() + " -- Currenntly completed: " + _timesComplete + "/" + _bonus;
    }
    public override string GetStringRepresentation()
    {
       return $"{base.GetStringRepresentation()}, {_bonus}, {_times}";
    }
    public override int RecordEvent()
    {
        Console.Write("How many times the goal was done?");
        int times = int.Parse(Console.ReadLine());
        _timesComplete = _timesComplete + times;
        if (_timesComplete >= _times)
        {
            return GetPoints() + _bonus;
        }
        return GetPoints();
    }
}