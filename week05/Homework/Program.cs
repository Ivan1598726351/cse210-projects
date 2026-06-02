using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Melvin Harris","Geometry");
        MathAssignment ma1 = new MathAssignment ("Lance Wilson", "Trigonometry", "section 2", "problems 1 and 2");
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeworkList());
        WrittingAssignemnt wa1 = new WrittingAssignemnt ("Carl Johnson", "History", "some title");
        Console.WriteLine(wa1.GetSummary());
        Console.WriteLine(wa1.GetWrittingInformation());
    }
}