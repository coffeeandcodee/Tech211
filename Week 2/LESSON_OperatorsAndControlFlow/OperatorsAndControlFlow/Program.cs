using Loops;
namespace OperatorsAndControlFlow;

public class Program
{
    static void Main()
    {
        #region Operators
        //int x = 5;
        //int y = 5;


        ////this is where things get weird
        //int w = x++;
        //int z = ++y;
        ////notice how w is 5 at this point, but z is 5
        ////the post increment specifices that the value is used in its context before incrementing (?)

        ////var
        //int n = 10;
        //var s = "wys";

        //var value = 5;
        //var myHalf = value / 2;
        ////compiler assumes pizza is an integer. 2 is also an integer, so it assumes it 

        //double otherHalf = value / 2;
        ////otherHalf is still 2. Remember assignment is done last, so RHS is still integer division 
        ////and rounding

        //var actualHalf = value / 2.0;
        ////since one of the avlues is a double, compiler interprets floating point division
        ////actualHalf is made 2.5

        ////modulus
        //int darkChocolate = 10;
        //int eaterz = 3;
        //int portion = darkChocolate / eaterz;
        //int leftOver = darkChocolate % eaterz;


        ////coditional expressions & logical operators
        //bool isComfortable = portion > 2 && leftOver > 0 || myHalf < value;

        ////short-cut evaluating
        //bool isWearingParachute = false;

        ////If the single ampersand is used, the method on the right is evaluated, and 
        ////you can hear the parachuter say WEEEEEEEE IM FALLINGGG!!!
        ////Double ampersand shortcuts this side effect
        //if (isWearingParachute && JumpOfAirplane())
        //{
        //    Console.WriteLine("SUCCESSFUL JUMP");
        //}

        //bool JumpOfAirplane()
        //{
        //    Console.WriteLine("WEEEEEEEE IM FALLINGGG!!!");
        //    return true;
        //}




        //string greeting = null;
        //// Throws exception because of lack of shortcutting
        ///*if (greeting != null & greeting.ToLower().StartsWith('a'))
        //{
        //    Console.WriteLine(greeting + " starts with 'a'");
        //}*/
        #endregion

        #region Control Flow
        ////Ternaries can be used to simply if-else chains, for example:
        //int height = 190;
        //string response = height > 185 ? "Oh you're tall" : "I wouldn't say you're tall";

        ////Switch
        //string law = "";
        //int age = 17;

        //switch (age)
        //{
        //    case < 18:
        //        law = "Cannot legally drive";
        //        break;
        //    case < 23:
        //        law = "Can legally drive, but cannot hire a car";
        //        break;
        //    default:
        //        law = "Can legally drive and rent a car";
        //        break;
        //}

        ////Item in foreach loop is READ ONLY. If value needs to be changed use for loop
        //List<int> nums = new List<int> { 10, 6, 22, -17, 3 };

        //Console.WriteLine("Highest number using a for loop: " + LoopExamples.HighestForLoop(nums));
        //Console.WriteLine("Highest number using a foreach loop: " + LoopExamples.HighestForEachLoop(nums));
        //Console.WriteLine("Highest number using a while loop: " + LoopExamples.HighestWhileLoop(nums));
        //Console.WriteLine("Highest number using a do-while loop: " + LoopExamples.HighestDoWhileLoop(nums));
        #endregion

        try
        {
            Console.WriteLine("His grade is: " + GetGrade(-1));
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }

    }

    //TO BE TESTED AS HOMEWORK
    public static string GetGrade(int grade)
    {
        //assume request that input is between 0 and 100

        //if data is invalid
        //This is THROWING exception if inputted.
        //Handling exception is HANDLING 

        if(grade < 0|| grade > 100)
        {
            throw new ArgumentOutOfRangeException("'grade' needs to be between 0 and 100");
        }


        return grade >= 65 ? grade >= 85 ? "You got a Distinction :O" : "You pass!" : "You fail :(";
    }
    




    private static string GetWeeksAndDays(int days)
    {
        int numberOfWeeks = days / 7;
        int numberOfDays = days % 7;
        string weekOrWeeks = numberOfWeeks > 1 ? "weeks" : "week";
        string dayOrDays = numberOfDays > 1 ? "days" : "day";

        return $"{numberOfWeeks} {weekOrWeeks} and {numberOfDays} {dayOrDays}";

    }


}