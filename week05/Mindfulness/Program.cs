using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;
//For creativity I will keep a log of how many times activities were performed.
class Program
{
    static void Main(string[] args)
    {
        int choice=0;
        int counterBreathing=0;
        int counterReflecting=0;
        int counterListing=0;
        while (choice != 5)
        {
            
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4.Log-times you performed the activity");
            Console.WriteLine("5. quit");

            Console.Write("Choose one of the options from the menu: ");
            choice = int.Parse(Console.ReadLine());

            if (choice ==1)
            {   
                Console.Clear();
                BreathingActivity ba1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                ba1.Run();
                counterBreathing=counterBreathing+1;
            }

            else if (choice==2)
            {   
                Console.Clear();
                ReflectingActivity ra1 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
                ra1.Run();
                counterReflecting=counterReflecting+1;
            }

            else if (choice==3)
            {
                Console.Clear();
                ListingActivity la1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                la1.Run();
                counterListing=counterListing+1;
            }


            else if (choice==4)
            {
                Console.Clear();
                Console.WriteLine($"You performed the breathing activity {counterBreathing} times");
                Console.WriteLine($"You performed the reflecting activity {counterReflecting} times");
                Console.WriteLine($"You performed the listing activity {counterListing} times");

            }

        }







    }
}