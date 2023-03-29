using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace Op_CtrlFlow;

/* MY notes written using multi-line syntax */

public class Exercises
{
    #region cleanup
    static void Main()
    {
        Console.WriteLine(MyMethod(1, 2));
    }
    public static bool MyMethod(int num1, int num2)
    {
        /*If num1 and num2 are equal, then false is returned
        //Otherwise, check if num1 is a GREATER multiple of num2. If so, return true
        /If not, return false*/

        return num1 == num2 ? false : (num1 % num2) == 0;
    }

    // returns the average of the array nums
    public static double Average(List<int> nums) 
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4 };
        /*'Queryable' Class part of the System.Linq library, defined above.
		The class contains 'AsQueryable()' method. 
		'AsQueryable' method converts an IEnumerable to an IQueryable*/
                                        
        var avg = numbers.Count != 0 ? Queryable.Average(numbers.AsQueryable()) : 0;      /*Note, this expression value promoted to double*/
        return avg;
    }

    // returns the type of ticket a customer is eligible for based on their age
    // "Standard" if they are between 18 and 59 inclusive
    // "OAP" if they are 60 or over
    // "Student" if they are 13-17 inclusive
    // "Child" if they are 5-12
    // "Free" if they are under 5
    public static string TicketType(int age)
    {
        string ticketType = string.Empty;
        return ticketType;
    }

    public static string Grade(int mark)
    {
        var grade = "";
        return grade;
    }

    public static int GetScottishMaxWeddingNumbers(int covidLevel)
    {
        return 0;
    }
    #endregion

    

}
