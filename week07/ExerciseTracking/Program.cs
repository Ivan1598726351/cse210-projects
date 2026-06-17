using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        List<Activity> _activities = new List<Activity>();
        while (choice != 5)
        {
        Console.WriteLine("Welcome to the Exercise tracking app. You can choose one of the activites to record or check your statistics.");
        Console.WriteLine("1. Running activity");
        Console.WriteLine("2. Swimming activity");
        Console.WriteLine("3. Cycling activity");
        Console.WriteLine("4.Check my statistics");
        Console.WriteLine("5. Quit");
        Console.Write("Choose one of the options: ");
        choice = int.Parse(Console.ReadLine());

        if (choice ==1)
            {
                Console.Write("Enter the duration of your run in minutes: ");
                int duration = int.Parse(Console.ReadLine());
                Console.Write("Enter the distance of your run in kilometers: ");
                double distance = double.Parse(Console.ReadLine());
                RunningActivity ra = new RunningActivity(duration,distance);
                _activities.Add(ra); 

            }
        else if (choice ==2)
            {
                Console.Write("Enter the number of laps you swam in a pool of lap length 50m: ");
                int numberOfLaps = int.Parse(Console.ReadLine());
                Console.Write("Enter the duration of your swimming in minutes: ");
                int duration = int.Parse(Console.ReadLine());
                SwimmingActivity sa = new SwimmingActivity(duration,numberOfLaps);
                _activities.Add(sa); 

            }

        else if (choice ==3)
            {
                Console.Write("Enter the speed setting of your bike in km/h ");
                double bikeSpeed = double.Parse(Console.ReadLine());
                Console.Write("Enter the duration of your cycling in minutes: ");
                int duration = int.Parse(Console.ReadLine());
                CyclingActivity ca = new CyclingActivity(duration,bikeSpeed);
                _activities.Add(ca); 

            }

        else if (choice==4)
            {
                foreach (Activity activity in _activities)
                {
                    Console.WriteLine(activity.GetSummary());
                }
            }

        }
    }
}