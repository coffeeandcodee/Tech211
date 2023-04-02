/*My notes written in multi-line syntax*/
namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static double Factorial(int n)
        {
            /*max value stored in int is 2,147,483,647.
             This value is exceeded at 17!, integer overflow
            "wraps" back around and starts from minimum negative integer, then adds the remainder of
            (17! - 2,147,483,647) to the minimum integerv (I think) to return a negative value
            Amended types to double to pass tests
            THERE IS A TRADEOFF REGARDLESS!!!*/
            double result = 1;
            for (double i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;

        }

        public static float Mult(float num1, float num2)
        {
            /*floats have 32 bits in memory */
            return num1 * num2;
        }
    }
}
