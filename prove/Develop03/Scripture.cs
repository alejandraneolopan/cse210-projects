using System.Numerics;

class Scripture
{
    private Reference _reference;   
    List<Word> _passage;
    public Scripture(string mainBook, string book, int chapter, int verse)
    {//1 verse
        _passage = new List<Word>();
        _reference = new Reference(mainBook, book, chapter, verse);
    }
    public Scripture(string mainBook, string book, int chapter, int startVerse, int endVerse)
    {
        _passage = new List<Word>();
        _reference = new Reference(mainBook, book, chapter, startVerse, endVerse);
    } 
    public void SetPassage(string text)
    {
        string[] passage = text.Split(" ");
        foreach (string word1 in passage)
        {
            Word word2 = new Word(word1);
            _passage.Add(word2);
        }
        
    }
    public string GetReference()
    {
        return _reference.GetReference();
    }
    public string GetPassage()
    {
        string passage = "";
        foreach(Word w in _passage)
        {
            passage = passage + " " + w.GetWord();
        }
        return(passage);
    }
    public void RemoveWords()
    {
        //Select randomly 3 words and hide
        Random random = new Random();
        int index, i = 1;
        while (i <= 3 && !IsEmpty())
        {
            index = random.Next(0, _passage.Count);
            if (_passage[index].IsShown())
            {
                _passage[index].Hide();
                i++;
            }
            
        }

    }
    public bool IsEmpty()
    {
        bool empty = true;
        foreach (Word w in _passage)
        {
            if (w.IsShown())
            {
                empty = false;
                break;
            }
        }
        return empty;
    }
}