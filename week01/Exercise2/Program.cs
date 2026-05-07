using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your score in percentages at the end of the course? ");
        string score_string = Console.ReadLine();
        int score = int.Parse(score_string);
        if (score >= 90)
        {
            letter="A";
            Console.WriteLine($"You got an {letter}");
        }

        else if (score >= 80)
        {
            letter="B";
            Console.WriteLine($"You got a {letter}");
        }

        else if (score >= 70)
        {
            letter="C";
            Console.WriteLine($"You got a {letter}");
        }

        else if (score >= 60)
        {
            letter="D";
            Console.WriteLine($"You got a {letter}");
        }

        else
        {
            letter="F";
            Console.WriteLine($"You got an {letter}");
        }

        if (score >= 70)
        {
            Console.WriteLine("You passed the class, congratulations");
        }
        else
        {
            Console.WriteLine("You failed the class, with more studying you will pass for sure next time");
        }


    }
}