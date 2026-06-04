public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>
    {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"    
    };
    public ReflectingActivity(string name, string description)
    :base(name, description)
    {
        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int number = random.Next(0, 4);
        string randomPrompt=_prompts[number];
        return randomPrompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int number = random.Next(0, 9);
        string randomQuestion=_questions[number];
        return randomQuestion;
    }

    public void DisplayQuestion()
    {
        Console.Write(GetRandomQuestion());
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetActivityDescription());
        int duration=GetActivityDuration();
        Console.Clear();
        Console.Write("Get ready...");
        ShowSpinner(2);
        Console.WriteLine("Consider the following prompt");
        DisplayPrompt();
        Console.WriteLine("When you think of something, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("You can now ponder on each of the following questions about this experience");
        Console.Write("You may begin in...");
        ShowCountDown(5);
        Console.Clear();
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }



}

