namespace OperatorsAndControlFlow;

public class Program
{
    static void Main()
    {
        int x = 5;
        int y = 5;


        //this is where things get weird
        int w = x++;
        int z = ++y;
        //notice how w is 5 at this point, but z is 5
        //the post increment specifices that the value is used in its context before incrementing (?)

        //var
        int n = 10;
        var s = "wys";

        var value = 5;
        var myHalf = value / 2;
        //compiler assumes pizza is an integer. 2 is also an integer, so it assumes it 

        double otherHalf = value / 2;
        //otherHalf is still 2. Remember assignment is done last, so RHS is still integer division 
        //and rounding

        var actualHalf = value / 2.0;
        //since one of the avlues is a double, compiler interprets floating point division
        //actualHalf is made 2.5

    }
}