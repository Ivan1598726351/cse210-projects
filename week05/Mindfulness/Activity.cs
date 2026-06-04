public class Activity
{
    private string _name;
    private string _description;
    public int _duration;

    public Activity(string name, string description)
    {
        _name=name;
        _description=description;
    }

    public int GetActivityDuration()
    {
        Console.Write("Enter the duration of the Activity: ");
        int duration = int.Parse(Console.ReadLine());
        _duration=duration;
        return _duration;


    }

    public string GetActivityName()
    {
        return _name;
    }

    public string GetActivityDescription()
    {
        return _description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {GetActivityName()}!");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done, you finished the activity!");
    }

    public void ShowSpinner(int seconds)
    {
        List <string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("—");
        animationStrings.Add("\\");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i=0;
        while(DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;
            
            if (i >= animationStrings.Count())
            {
                i=0;
            }
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i=seconds; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}