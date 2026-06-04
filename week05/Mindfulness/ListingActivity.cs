public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description)
    :base(name, description)
    {
        
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(0, 5);
        string randomPrompt=_prompts[number];
        Console.WriteLine(randomPrompt);
    }

    public void Run()
    {
        _count=0;
        DisplayStartingMessage();
        Console.WriteLine(GetActivityDescription());
        int duration=GetActivityDuration();
        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(2);
        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in...");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("");
            Console.ReadLine();
            _count=_count+1;
        }

        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();

    }



}