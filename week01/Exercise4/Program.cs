using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers and type 0 when finished.");
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter your number: ");
            string inserted_number = Console.ReadLine();
            number = int.Parse(inserted_number);
            if (number != 0)
            {
                numbers.Add(number);
            }
            else
            {
                continue;
            }
        }
        int summation;
        summation=0;
        for (int i = 0; i < numbers.Count; i++)
        {
            summation=summation+numbers[i];
        }
        Console.WriteLine($"the sum is {summation}");
        float average;
        average=(float)summation/numbers.Count;
        Console.WriteLine($"The average is {average}");
        int maxi;
        maxi=numbers.Max();
        Console.WriteLine($"The maximum number is {maxi}");
        

    }
}