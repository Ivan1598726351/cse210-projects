using System.Globalization;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
    :base(name, description)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetActivityDescription());
        int duration=GetActivityDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(2);
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(4);
            Console.WriteLine();
        }
        Console.WriteLine();
        DisplayEndingMessage();
        
    }




}