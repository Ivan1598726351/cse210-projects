using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString(f1.GetTop(),f1.GetBottom()));
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString(f2.GetTop(),f2.GetBottom()));
        Fraction f3 = new Fraction(5,71);
        Console.WriteLine(f3.GetFractionString(f3.GetTop(),f3.GetBottom()));
        Fraction f4 = new Fraction();
        f4.setTop(4);
        f4.setBottom(5);
        Console.WriteLine(f4.GetFractionString(f4.GetTop(),f4.GetBottom()));
        Console.WriteLine(f4.GetDecimalNumber(f4.GetTop(),f4.GetBottom()));
    }
}