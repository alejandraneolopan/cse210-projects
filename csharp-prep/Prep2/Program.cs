using System;

class Program
{
    static void Main(string[] args)
    {
        int grade;
        char gradeText;
        int additionalPoints;
        string sign;
        sign = "";
        Console.Write("Enter your grade percentage (0-100): ");
        grade = int.Parse(Console.ReadLine());
        
        if (grade >= 90)
        {
            gradeText ='A';
        }
        else if (grade >= 80)
        {
            gradeText ='B';
        }
        else if (grade >= 70)
        {
            gradeText ='C';
        }
        else if (grade >= 60)
        {
            gradeText ='D';
        }
        else 
        {
            gradeText ='F';
        }
        additionalPoints = grade % 10;
        if (additionalPoints >= 7 && additionalPoints<10 && gradeText != 'A' && gradeText != 'F')
        {
            sign = "+";
        }
        else if (additionalPoints < 3 && additionalPoints>0 && gradeText != 'F')
        {
            sign = "-";
        }
        Console.WriteLine($"You got {gradeText}{sign}");  

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! you approved the course.");
        }
        else
        {
            Console.WriteLine("You will got it next time.");
        }

    }
}