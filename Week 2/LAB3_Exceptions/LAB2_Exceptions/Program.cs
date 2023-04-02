namespace LAB2_Exceptions;
using System;

public class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        var _list = new List<int> { };

        try
        {
            Average(_list);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception caught");
            Console.WriteLine(e.Message);
        }

    }


    public static double Average(List<int> nums)
    {
        #region Queryable class notes
        /*'Queryable' Class part of the System.Linq library, imported above.
		The class contains 'AsQueryable()' method. 
		'AsQueryable' method converts an IEnumerable to an IQueryable*/
        #endregion
       
        //Checking for invalid argument
        if(nums.Count == 0)
        {
            throw new ArgumentNullException("Emptyyyyyyyyyy list");
        }



        /*Method returns 0 if list is empty*/
        // var avg = nums.Count == 0 ? 0 : Queryable.Average(nums.AsQueryable());      /*Note, this expression value promoted to double*/
        var avg = nums.Count == 0 ? 0 : Queryable.Average(nums.AsQueryable());

        return avg;
    }


}