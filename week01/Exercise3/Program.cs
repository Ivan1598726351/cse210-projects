using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Pick the magic number? ");
        //string magic_number = Console.ReadLine();
        //int number = int.Parse(magic_number);
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = -1;
        while (guess != number)
        {    
            Console.Write("What is your guess? ");
            string guess_number = Console.ReadLine();
            guess = int.Parse(guess_number);
            if (guess < number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess > number)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed the number");
            }
        }
    }
}