class Word
{
    string _word;
    bool shown;

    public Word(string word)
    {
        _word = word;
        shown = true;
    }
    public void Hide()
    {
        char[] characters = _word.ToCharArray();
        string newWord = "";
        char newChar;
        foreach (char c in characters)
        {
            newChar = c;
            if (Char.IsLetter(c))
            {
                newChar = '_';
            }
            newWord = newWord + newChar;
        }
        _word = newWord;
        shown = false;
    }
    public bool IsShown()
    {
        return shown;
    }
    public string GetWord()
    {
        return _word;
    }
}