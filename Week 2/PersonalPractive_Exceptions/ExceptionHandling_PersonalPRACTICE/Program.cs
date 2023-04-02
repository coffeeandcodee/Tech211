using System.Diagnostics;

namespace PRACICE;
//Learning exception handling via method assessed in previous Lab

public class Program
{
    static void Main()
    {
        try
        {
            AvailableClassifications(-5);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("EXCEPTION CAUGHT");
            Console.WriteLine(e.Message);
        }
    }

    //Looking for ArgumentOutOfRangeException
    public static string AvailableClassifications(int ageOfViewer)
    {
        //Checking for exceptions
        if (ageOfViewer < 0 || ageOfViewer > 300) 
        {
            throw new ArgumentOutOfRangeException("'grade' needs to be between 0 and 100");
        }

        string result;
        if (ageOfViewer < 12)
        {
            result = "U & PG films available.";
        }
        else if (ageOfViewer < 15)
        {
            result = "U, PG & 12 films available.";
        }
        else if (ageOfViewer < 18)
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

