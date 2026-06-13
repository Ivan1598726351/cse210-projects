using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager gm = new GoalManager();


        int choice =0;
        while (choice !=6)
        {
            Console.WriteLine(gm.DisplayPlayerInfo());
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine();
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice=int.Parse(Console.ReadLine());
            if (choice ==1)
            {
                Console.WriteLine("The types of goals are:");
                Console.WriteLine("1. Simple goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Checklist goal");
                Console.Write("What type of goal would you like to create? ");
                int chosenGoal=int.Parse(Console.ReadLine());
                if (chosenGoal==1)
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName=Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription=Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints=int.Parse(Console.ReadLine());
                    SimpleGoal sg = new SimpleGoal(goalName,goalDescription,goalPoints,false);
                    gm.AddGoal(sg);
                }
                if (chosenGoal==2)
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName=Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription=Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints=int.Parse(Console.ReadLine());
                    EternalGoal eg = new EternalGoal(goalName,goalDescription,goalPoints);
                    gm.AddGoal(eg);

                }
                if (chosenGoal==3)
                {
                    Console.Write("What is the name of your goal? ");
                    string goalName=Console.ReadLine();  
                    Console.Write("What is a short description of it? ");
                    string goalDescription=Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int goalPoints=int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int goalTarget=int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int goalBonus=int.Parse(Console.ReadLine());
                    ChecklistGoal clg = new ChecklistGoal(goalName,goalDescription,goalPoints,0,goalTarget,goalBonus);
                    gm.AddGoal(clg);

                }
                
            }
            
            if (choice==2)
                {
                    Console.WriteLine("The goals are:");
                    gm.ListGoalDetails();
                }

            if (choice==5)
            {
                Console.WriteLine("The goals are:");
                gm.ListGoalNames();  
                Console.Write("Which goal did you accomplish? ");
                int accomplishedGoal = int.Parse(Console.ReadLine());
                Goal selectedGoal =gm.GetListOfGoals()[accomplishedGoal-1];
                gm.RecordEventGoalManager(selectedGoal);
                Console.WriteLine();


            }

            if (choice==3)
            {
                gm.SaveGoals();
            }

            if (choice==4)
            {
                gm.LoadGoals();
            }

        }
    }
}