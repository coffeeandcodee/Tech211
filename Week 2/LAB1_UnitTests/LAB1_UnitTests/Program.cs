using System;
using System.Diagnostics;

namespace LAB1_UnitTests;


public class Program
{
    static void Main()
    {

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
            result = "U, PG & 12 films available.";
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
    public static string GetGrade(int Grade)
    {
        //return grade >= 65 ? grade >= 85 ? "You got a Distinction :O" : "You pass!" : "You fail :(";
        return Grade >= 65 ? Grade >= 85 ? "You got a Distinction :O" : "You pass!" : "You fail :(";

    }

}