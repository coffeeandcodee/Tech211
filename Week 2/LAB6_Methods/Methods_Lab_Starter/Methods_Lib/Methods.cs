using System;

namespace Methods_Lib;

public class Methods
{
    // implement this method so it returns a tuple (weeks, days) 
    // corresponding to a given number of days
    public static (int weeks, int days) DaysAndWeeks(int totalDays)
    {
        if (totalDays < 0)
        {
            throw new ArgumentOutOfRangeException("totalDays must not be negative");
        }
        return (totalDays / 7, totalDays % 7);

    }

    /*Remember return parameters need to be named if a tuple is to be returned*/
    public static (int square, int cube, double root) PowersRoot(int n)
    {
      
        
        int square = n * n;
        int cube = n * n * n;
        //Math.Round(Double <value>, int <decimalPlaces>)
        double root = Math.Round(Math.Sqrt(n), 2); ;
        return (square, cube, root);
    }

    public static int RollDice(Random rng)
    {

        var num1 = rng.Next(1, 7);
        var num2 = rng.Next(1, 7);
        return num1 + num2;

    }
}
