using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Guess My Number game the computer picks a magic number, and then the user tries to guess it. 
        int magicNumber=0;
        int userGuess;
        byte times = 0;
        Random randomNumber = new Random();
        magicNumber = randomNumber.Next(1, 100);

        do{
            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());
            if (magicNumber == userGuess)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (magicNumber > userGuess)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("Lower");
            }

            times ++;

        }while(magicNumber != userGuess);
        
        Console.WriteLine($"Number of attempts: {times}");
      
    }
}