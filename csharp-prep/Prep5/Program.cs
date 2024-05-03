using System;

class Program
{
    static void Main(string[] args)
    {
        string userName;
        int userNumber;
        int squared;
        DisplayWelcome();
        userName = PromptUserName();
        userNumber = PromptUserNumber();
        squared = SquareNumber(userNumber);
        DisplayResult(userName, squared);
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        string name;
        Console.Write("Please enter your name: ");
        name = Console.ReadLine();
        return name;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int number)
    {
        string lastName = GetLastName(name);
        Console.WriteLine($"Brother {lastName}, the square of your number is {number}");
    }
    static string GetLastName(string fullName)
    {
        string[] names;
        names = fullName.Split(" ");
        return names[names.Length-1];
    }
}