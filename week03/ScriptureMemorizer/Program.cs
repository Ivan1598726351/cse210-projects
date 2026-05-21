using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Alma",37,36);
        Scripture scripture = new Scripture(reference, "Yea, and cry unto God for all thy support; yea, let all thy doings be unto the Lord, and whithersoever thou goest let it be in the Lord; yea, let all thy thoughts be directed unto the Lord; yea, let the affections of thy heart be placed upon the Lord forever.");
        Console.WriteLine(scripture.GetDisplayText());
        string choice=" ";
        while (choice != "quit")
        {
            Console.WriteLine("Press enter to hide text or quit to exit");
            choice = Console.ReadLine();
            if (choice=="quit")
            {
                break;
            }
            Console.Clear();
            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
            
            if (scripture.IsCompletelyHidden()==true)
            {
                break;
            }
            


        }
        
        

    }
}