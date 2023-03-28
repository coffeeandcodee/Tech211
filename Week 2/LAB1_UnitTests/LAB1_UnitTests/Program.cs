using System;

namespace LAB1_UnitTests;


public class Program
{
    static void Main()
    {
        if (Method1() && Method2())
        {
            Console.WriteLine("If you're seeing this then both methods declared below executed");
        }

        bool Method1()
        {
            Console.WriteLine("This method will always execute!");
            Random rand = new Random();
            int oneOrTwo = rand.Next(1, 3);
            bool result = (oneOrTwo == 2) ? true : false;
            return result;
        }
        bool Method2()
        {
            Console.WriteLine("Might execute, it might not ¯_(ツ)_¯");
            return true;
        }

    }

    //Method amended according to bbfc guidelines 
    public static string AvailableClassifications(int ageOfViewer)
    {
       
        string result;
        if (ageOfViewer < 12)
        {
            result = "U & PG films available.";
        }
        else if (ageOfViewer < 15)
        {
            result = "U, PG, & 12 films available.";
        }
        else if(ageOfViewer < 18)
        {
            result = "U, PG, 12 & 15 films available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;
    }
}