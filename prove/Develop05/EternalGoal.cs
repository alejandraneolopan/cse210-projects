class EternalGoal: Goal
{
    public EternalGoal(string name, string desc, int points): base(name, desc, points)
    {
        
    }
    public override string GetStringRepresentation()
    {
       return $"{GetType()}:{GetName()},{GetShortDescription()},{GetPoints()}";
    }
}