class Goal
{
    string _name;
    string _shortDescription;
    int _points;
    bool _complete;
    public Goal(string name, string description, int points)
    {
        _name = name;
        _shortDescription = description;
        _points = points;
        _complete = false;

    }
    public Goal(string name, string description, int points, bool complete)
    {
        _name = name;
        _shortDescription = description;
        _points = points;
        _complete = complete;

    }
    public virtual int RecordEvent()
    {
        _complete = true;
        return _points;
    }
    public bool IsComplete()
    {
        return _complete;
    }
    public virtual string GetDescription()
    {
        return $"{_name} ({_shortDescription})";
    }
    public virtual string GetStringRepresentation()
    {
       return $"{GetType()}:{_name},{_shortDescription},{_points},{_complete}";
    }
    public string GetName()
    {
        return _name;
    }
    public string GetShortDescription()
    {
        return _shortDescription;
    }
    public int GetPoints()
    {
        return _points;
    }
}