using System;

class Program
{
    static void Main(string[] args)
    {
        List <string> prompts = new List<string>();
        prompts.Add("What did you do today?");
        prompts.Add("What was the most interesting thing that happened to you today?");
        prompts.Add("If I had one thing I could redo today, what would it be?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("What was the strongest emotion I felt today?");
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal program. Choose one of the options: ");
        int choice = -1;
        while (choice != 5)
        {
            Console.WriteLine("1 Write into Journal");
            Console.WriteLine("2 Display Journal");
            Console.WriteLine("3 Load Journal");
            Console.WriteLine("4 Save Journal");
            Console.WriteLine("5 Quit");
            Console.Write("Enter your choice: ");
            string inserted_choice = Console.ReadLine();
            choice = int.Parse(inserted_choice);

            if (choice == 1)
            {
                Entry entry = new Entry();
                string randomPrompt=prompts[getRandomNumber()];
                entry._promptText=randomPrompt;
                Console.WriteLine(randomPrompt);
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry._date=dateText;
                Console.Write("");
                string answer = Console.ReadLine();
                entry._entryText=answer;
                journal._entries.Add(entry);




            }

            else if (choice==2)
            {
                journal.Display();
            }

            else if (choice==3)
            {
                journal.ReadFromFile();
            }


            else if (choice==4)
            {
                journal.SavetoFile();
            }



        }


    }

    static int getRandomNumber()
    {
    Random randomGenerator = new Random();
    int number = randomGenerator.Next(0, 5);
    return number;
    }



}