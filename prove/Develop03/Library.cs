class Library
{
    string _book;
    List<Scripture> _scriptures;

    public Library()
    {
        //Load scriptures from the text files
        _book = "OldTestament";
        ReadScriptures(_book);  

    }
    public Library(string book)
    {
        //Load scriptures from the text files
        _book = cleanUpBook(book);
        ReadScriptures(_book);  

    }
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(0,_scriptures.Count - 1);
        return _scriptures[index];
    }
     
    private string cleanUpBook (string book)
    {
        string newBook = "";
        string[] cleanBook = book.Split(" ");
        foreach (string element in cleanBook)
        {
            newBook = newBook + capitalizedWord(element);
        }
        return newBook;
    }
    private string capitalizedWord (string word)
    {
        string capitalLetter = word.Substring(0, 1).ToUpper();
        string capitalWord = word.Substring(1, word.Length-1).ToLower();
        return capitalLetter + capitalWord;
    }

    private void ReadScriptures(string book)
    {
        List<Scripture> setOfScriptures = new List<Scripture>();
        string filename = book + ".txt";
        string subBook = "";
        int chapter = 0;
        int startVerse = 0;
        int endVerse = 0;
        string[] referenceParts;
        string[] referenceBook;
        string[] verses;
        string[] lines = System.IO.File.ReadAllLines(filename);
        Scripture scripture;
        string passage;
        string text;
  
        for(int i = 0; i < lines.Length; i++)
        {
            passage = lines[i];
            referenceParts = passage.Split(":");
            referenceBook = referenceParts[0].Split(" ");
            verses = referenceParts[1].Split("–");
            if (referenceBook.Length > 2)
            {
                subBook = "";
                for (int j = 0; j < referenceBook.Length - 1; j ++)
                {
                    subBook = subBook + " " + referenceBook[j];
                }
                chapter = Int32.Parse(referenceBook[referenceBook.Length]);
            }
            else
            {
                subBook = referenceBook[0];
                chapter = Int32.Parse(referenceBook[1]);
            }
            startVerse = Int32.Parse(verses[0]);
            endVerse = startVerse;
            if (verses.Length > 1)
            {
                endVerse = Int32.Parse(verses[1]);
                scripture = new Scripture(book,subBook,chapter, startVerse, endVerse);
                passage = "";
            }
            else
            {
                 scripture = new Scripture(book,subBook,chapter, startVerse);
            }
            text = "";
            for (int k = startVerse; k <= endVerse; k++)
            {
                i++;
                text = text + (char)10 + (char)13 + lines[i];
            }
            scripture.SetPassage(text);
            setOfScriptures.Add(scripture);
        }
        _scriptures = setOfScriptures;
        
    }
}