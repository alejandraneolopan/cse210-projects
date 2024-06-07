class MathAssignment: Assignment
{
    string _textbookSection;
    string _problems;

    public MathAssignment(string text, string problem, string name, string topic):base(name, topic)
    {
        _textbookSection = text;
        _problems = problem;
    }
    public  string GetHomeworkList() 
    {
        return ($"Section {_textbookSection} Problems {_problems}");

    }

}