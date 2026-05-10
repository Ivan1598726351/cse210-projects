using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        
        
        
        DisplayMessage();
        string user_name=PropmptUserName();
        int favorite_number=PropmptUserNumber();
        int squared = SquareNumber(favorite_number);
        DisplayResult(squared,user_name);

        
        
    }

    static void DisplayMessage()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PropmptUserName()
        {
            Console.Write("Enter your name ");
            string user_name = Console.ReadLine();
            return user_name;
        }
        static int PropmptUserNumber()
        {
            Console.Write("Enter your favorite number ");
            string fav_number= Console.ReadLine();
            int favorite_number=int.Parse(fav_number);
            return favorite_number;
        }        

        static int SquareNumber(int number)
        {
            int squared = number*number;
            return squared;
        }
        
        static void DisplayResult(int number, string name)
        {
            Console.WriteLine($"Hello {name}, the square of your favorite number is {number}");

        }
                            



}
