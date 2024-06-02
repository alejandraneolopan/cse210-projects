class Reference
{
    string _mainBook;
    string _book;
    int _chapter;
    int _startVerse;
    int _endVerse;
    public Reference(string mainBook, string subBook, int chapter, int startVerse, int endVerse)
    {
        _mainBook = mainBook;
        _book = subBook;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;

    }
    public Reference(string mainBook, string subBook, int chapter, int startVerse)
    {
        _mainBook = mainBook;
        _book = subBook;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;

    }
    public string GetReference()
    {
        string label;
        if (_startVerse == _endVerse)
        {
            label = $"{_book} {_chapter}:{_startVerse}";
        }
        else
        {
            label = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        
        return label;
    }
}
