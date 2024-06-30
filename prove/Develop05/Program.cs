using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        char answer, goalType;
        string goalName, goalDesc;
        int goalPoints, applyForBonus, bonus;
        string filename;
        Gamification game = new Gamification();
        do
        {
            Console.WriteLine($"You have {game.GetTotals()} points.");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            answer = char.Parse(Console.ReadLine());
            switch(answer)
            {
                case '1':
                    Console.WriteLine("The types  of Goals are:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("What type of goal do you like to create? ");
                    goalType = char.Parse(Console.ReadLine());
                    Console.Write("What is the name of your goal? ");
                    goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    goalDesc = Console.ReadLine();
                    Console.Write("What is the amount of points associated  with this goal? ");
                    goalPoints = int.Parse(Console.ReadLine());
                    switch (goalType)
                    {
                        case '1':
                        SimpleGoal goal1 = new SimpleGoal(goalName, goalDesc, goalPoints);
                        game.AddGoal(goal1);
                        break;
                        case '2':
                        EternalGoal goal2 = new EternalGoal(goalName, goalDesc, goalPoints);
                        game.AddGoal(goal2);
                        break;
                        case '3':
                        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                        applyForBonus = int.Parse(Console.ReadLine());
                        Console.Write("What is the bonus for accomplishing it that many times? ");
                        bonus = int.Parse(Console.ReadLine());
                        Checklist goal3 = new Checklist(goalName, goalDesc, goalPoints,bonus, applyForBonus);
                        game.AddGoal(goal3);
                        break;
                    }
                break;
                case '2':
                    game.ShowGoals();
                break;
                case '3':
                    Console.Write("What is the  filename for the goal file? ");
                    filename = Console.ReadLine();
                    game.SaveGoals(filename);
                break;
                case '4':
                    Console.Write("What is the  filename for the goal file? ");
                    filename = Console.ReadLine();
                    game.LoadGoals(filename);
                break;
                case '5':
                    List<Goal> incompletes = game.ListIncompleteGoals();
                    Console.Write("Which goal did you accomplish? ");
                    int option = int.Parse(Console.ReadLine()) - 1;
                    goalPoints = incompletes[option].RecordEvent();
                    Console.WriteLine($"Congratulations! You have earned {goalPoints} points!");
                    game.Reward(goalPoints);
                    Console.WriteLine($"You now have {game.GetTotals()} points");
                break;

            }

        }while(answer != '6');
        
    }
}