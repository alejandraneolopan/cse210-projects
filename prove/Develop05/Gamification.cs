using System.IO; 
class Gamification
{
    int _accumulatedPoints;
    List<Goal> _goals;
    public Gamification()
    {
        _goals = new List<Goal>();
        _accumulatedPoints = 0;
    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void ShowGoals()
    {
        string complete = "";
        Console.WriteLine("The goals are:");
        int order = 1;
        foreach(Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                complete = "X";
            }
            else
            {
                complete = " ";
            }
            Console.WriteLine($"{order}. [{complete}] {goal.GetDescription()}");
            order++;
        }
    }
    public void Reward(int points)
    {
        _accumulatedPoints = _accumulatedPoints + points;
    }
    public void LoadGoals(string filename)
    {
        string objectClass;
        string[] parts, attributes;
        string[] lines = System.IO.File.ReadAllLines(filename);
        _accumulatedPoints = int.Parse(lines[0]);
        for (int i = 1; i< lines.Length; i++)
        {
            parts = lines[i].Split(":");

            objectClass = parts[0];
            attributes = parts[1].Split (",");
            if (objectClass == typeof(SimpleGoal).FullName)
            {
                _goals.Add(new SimpleGoal(attributes[0], attributes[1], int.Parse(attributes[2]), bool.Parse(attributes[3])));
            }
            if (objectClass == typeof(EternalGoal).FullName)
            {
                _goals.Add(new EternalGoal(attributes[0], attributes[1], int.Parse(attributes[2])));
            }
            if (objectClass == typeof(Checklist).FullName)
            {
                _goals.Add(new Checklist(attributes[0], attributes[1], int.Parse(attributes[2]),int.Parse(attributes[3]), int.Parse(attributes[4])));
            }
            
        }
    }
    public void SaveGoals(string filename)
    {
        string serialized;
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_accumulatedPoints);

            foreach(Goal goal in _goals)
            {
                serialized = goal.GetStringRepresentation();
                outputFile.WriteLine(serialized);
            }
        }
    }
    public List<Goal> ListIncompleteGoals()
    {
        List<Goal> incompletes = new List<Goal>();
        Console.WriteLine("The goals are:");
        int order = 1;
        foreach(Goal goal in _goals)
        {
            if (!goal.IsComplete())
            {
                Console.WriteLine($"{order}. {goal.GetName()}");
                incompletes.Add(goal);
                order++;
            }
        }
        return incompletes;
    }
    public int GetTotals()
    {
        return _accumulatedPoints;
    }
}