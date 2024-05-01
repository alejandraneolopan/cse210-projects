using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        int number;
        List<int> series = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do{
        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        series.Add(number);
        }while (number != 0);

        int sum = 0;
        int max = -99999;
        foreach (int element in series)
        {
            sum = sum + element;
            if (element > max)
            {
                max = element;
            }
        }
        
        decimal avg = 0;
        if (series.Count > 0 )
        {
            avg = sum/series.Count;
        }

        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + avg);
        Console.WriteLine("The largest number is: " + max);

    }
}