using System;

namespace DataTypes_Lib
{
    public static class IntegerCalc
    {
        /*int --- 32 bit (8 bytes) signed integer. Range: -2,147,483,648 to 2,147,483,647 (0000...[x 8] being -2,147...*/
        public static int Add(int num1, int num2)
        {
            /*If both ints are positive, but their sum is negative, there must be an OverflowException (?)
             When exceeding int.MaxValue, the result "wraps back around" from int.MinValue*/
            checked
            {
                int sum = num1 + num2;
            }
            /*Mirrored logic from above. || has lower precedence than && so I could've added the below conditional to the 
             one above, but made seperate for readability*/
            
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            checked
            {

            }

            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            //CREATE TESTS 
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            if (num2 == 0)
            {
                /*Remember, C# exceptions are represented by CLASSES (hence () at the end ?)*/
                throw new ArgumentException("Can't divide by zero");
            }

            /*When dividing an int by a non-factor int, the decimal part is TRUNCATED
              e.g 10/3 returns 3, not 3.3333...*/
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException("Can't modulo by zero");
            }

            return num1 % num2;


        }
    }
}
