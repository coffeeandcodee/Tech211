using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace Op_CtrlFlow;

/* MY notes written using multi-line syntax */

public class Exercises
{
    
    static void Main()
    {
        
    }

    #region MyMethod
    public static bool MyMethod(int num1, int num2)
    {
  

        return num1 == num2 ? false : (num1 % num2) == 0;
    }
    #endregion

    #region Average
    public static double Average(List<int> nums) 
    {
        #region Queryable class notes
        /*'Queryable' Class part of the System.Linq library, defined above.
		The class contains 'AsQueryable()' method. 
		'AsQueryable' method converts an IEnumerable to an IQueryable*/
        #endregion

        /*Method returns 0 if list is empty*/
        var avg = nums.Count == 0 ? 0 : Queryable.Average(nums.AsQueryable()) ;      /*Note, this expression value promoted to double*/
        return avg;
    }
    #endregion

    #region TicketType requirements
    // returns the type of ticket a customer is eligible for based on their age
    // "Standard" if they are between 18 and 59 inclusive
    // "OAP" if they are 60 or over
    // "Student" if they are 13-17 inclusive
    // "Child" if they are 5-12
    // "Free" if they are under 5
    #endregion

    #region TicketType method
    public static string TicketType(int age)
    {
        string ticketType = string.Empty;
        switch (age)
        {
            case < 5:
                ticketType = "Free";
                break;
            case < 13:
                ticketType = "Child";
                break;
            case < 18:
                ticketType = "Student";
                break;
            case < 60:
                ticketType = "Standard";
                break;
            default:
                ticketType = "OAP";
                break;
        }

        return ticketType;
    }
    #endregion

    public static string Grade(int mark)
    {
        //NOTE: come back and create nested if-statements 
        var grade = "";
        switch (mark)
        {
            case < 40: grade = "Fail"                   ; break;
            case < 60: grade = "Pass"                   ; break;
            case < 75: grade = "Pass with Merit"        ; break;
            case < 101: grade = "Pass with Distinction"  ; break;

        }
        return grade;
    }


    public static int GetScottishMaxWeddingNumbers(int covidLevel)
    {
        int result;
        switch (covidLevel)
        {
            case < 1: result = 200; break;
            case < 2: result = 100; break;
            case < 4: result = 50; break;
            case < 5: result = 200; break;

        }
        return 0;
    }
    

    

}
