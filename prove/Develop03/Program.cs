using System;

class Program
{
    static void Main(string[] args)
    {
        
        Scripture scripture;
        Library library;
        string answer, reference, passage, book;
        bool x, y, z, firstTime = true;
        Console.Write("Enter a book (Old Testament, New Testament, Book Of Mormon, Doctrine And Covenants) : ");
        book = Console.ReadLine();
        if (book.Length < 1)
        {
            library = new Library();
        }
        else
        {
            library = new Library(book);
        }
        scripture = library.GetRandomScripture();
        reference = scripture.GetReference();

        do{
            if (!firstTime)
            {
                scripture.RemoveWords();
            }
            // This will clear the console
            Console.Clear();
            Console.WriteLine(reference);
            passage = scripture.GetPassage();
            Console.Write(passage);
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            answer = Console.ReadLine();
            if (firstTime)
            {
                firstTime = false;
            }
        }while(answer.ToLower() != "quit" && !scripture.IsEmpty() && answer == "");

    }
}