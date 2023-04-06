using System.Text;
using System;
namespace DataTypesApps


{//type declaration. Same level as class, therefore 
    // defined outside of Program class
    public enum Suit
    {
        HEARTS, 
        CLUBS,
        DIAMONDS = 99,  //const 
        SPADES

    }
    //LOOK BACK ON CONVERSION TABLES in lecture 
    internal class Program
    {
        static void Main()
        {
            #region Numericals
            
            //C# is STATICALLY TYPED, meaning 1 - variable must be declared with known type
            int n = 10;
            var x = n;
            //2 - type safe.Type of variable CANNOT be changed
            //n = "string"; <---- Won't compile

            //C# is MEMORY SAFE
            //1 - Have a garbage collector
            //2 - Cannot directly access memory like in C++ * (or at least it is NOT convention)
            //3 - Types have a fixed memory size. Types cannot be changed, so we know how much memory we'll need

            n = 1000;
            //Size of n in memory is still 64  bits

            float f = 9f;
            float f2 = 9;
            //without f, RHS (data literal?) initally evaluated as int. f2 is still a float at the end

            //Integral types have absolute accuracy. You'll never lose data
            //As opposed with floating point types(f, d, m) there's varying precision. You can lose data
            //float is mostly used in graphic libraries for high processing power due to its small range.
            //double is mostly used for calculations in programming to eliminate errors when decimal values are being rounded off
            float sum = 0;
            for (int i = 0; i < 1_000_000; i++)
            {
                sum += 2 / 5f;      //float only holds 32 bits. Remaining bits after the 32 are truncated
            }                       //resulting in imprecise rounding
           
            Console.WriteLine(sum);
            //Can be seen that sum is NOT 400,000

            //Safe Type conversions
            sum = 10; //float <-- int coversion valid, as there's no data loss
            long l = n; // long <--- int into long, valid
            uint population = 68_000_000;
            l = population; // <---- long <--- uint
                            // n = population uint into int is not OK. unsafe conversion 

            //overflow and underflow

            //checked
            //{

            //    byte cows = 150;
            //    cows += 150;
            //    //byte cows = 0
            //    //cows -= 150 would be underflow

            //    Console.WriteLine("COWS: " + cows);

            //}

            //Unsafe conversions WATCH RECORDING
            int students = 16;
            byte bStudents = Convert.ToByte(students);

            //casting
            bStudents = (byte)students;

            int bankBalance = 2;
            uint bankBalanceUInt;
            bankBalance -= 9000;
            bankBalanceUInt = (uint)bankBalance;

            //Convert.ToString converts the int/uint into binary
            //rep

            Console.WriteLine("Bank Balance is: ");
            Console.WriteLine(bankBalance);
            Console.WriteLine(Convert.ToString(bankBalance, 2));
            Console.WriteLine();
            Console.WriteLine("Bank Balance UInt is: ");
            Console.WriteLine(bankBalanceUInt);

            //First digit 1 for negatives, 0 for positives 
            Console.WriteLine(Convert.ToString(bankBalanceUInt, 2));
            
            #endregion

            #region Strings
            Console.WriteLine(newString(" C# list fundamentals "));
            //Strings are IMMUTABLE

            //string interpolation
            int cheeseStock = 10;
            string cheese = "Cheddar";
            //variables can be altered in interpolation
            Console.WriteLine($"I have {cheeseStock/2} units of {cheese.ToUpper()} in stock");

            //ignoring specials using @
            string aLiteralString = @"CL\Users\yeahh";

            //rounds to 3 decimals
            Console.WriteLine($"Log example: {Math.Log(2, 7):0.###}");
            //:C for currency 
            Console.WriteLine($"That would be {2/7d:C}");

            int[] arr = { 1, 3, 4 };

            Console.WriteLine("Provide number");
            int NUM = Int32.Parse(Console.ReadLine());
            //TryParse
            int N;
            bool inputOk = Int32.TryParse(Console.ReadLine(), out N);
            Console.WriteLine($"Input was {(inputOk ? "" : "not")} OK");



            #endregion

            #region Arrays

            //Arrays are also objects 
            //single dimension
            //arr is somewhere else?
            int[] arrr = { 1, 4, 5, 6 };
            int[] arrClassic = new int[5];

            
            //Multi-dimensional 
            //Sub arrays MUST same lengths
            int[,] a2DArray =
            {
                {1, 2, 4},
                {9, 8, 7},
                {4, 3, 2 },

            };

            foreach(var item in a2DArray)
            {
                //loops over items seemingly linearly 
                //Similar to 1D array
                //As a data structure, its one long array, 
                //Secretely a single array with multiple indices to access
                Console.WriteLine(item);
            }

            //Jagged Arrays

            //Before you can use a jagged array, its elements must be initialized. You can initialize the elements like this:
            //1.
            int[][] myJaggedArray =
            {
                new int[] {1, 2, 3 },
                new int[] {4, 5 }
            };



            Console.WriteLine("Jagged: " + myJaggedArray[1][0]);
            //2.
            //initalizing without defining
            int[][] myjaggedArray2 = new int[2][];
            myjaggedArray2[0] = new int[3];
            myjaggedArray2[1] = new int[2];



            int[][] anotherJaggedArray2 = new int[3][];
            anotherJaggedArray2[0] = new int[13];
            anotherJaggedArray2[1] = new int[1];


            int[][] jagged = new int[2][]


            myjaggedArray2[0][1] = 99;
            Console.WriteLine(myjaggedArray2[1][1]);

            Console.WriteLine();
            foreach(var item in myJaggedArray)
            {
                foreach(var number in item)
                {
                    Console.Write(number);
                }
            }
            #endregion

            #region DateTime
            //Is a struct, not a class

            Console.WriteLine();
            Console.WriteLine(DateTime.Now);

            #endregion

            #region Enums
            //Enums - enumerated types
            //fixed collection of constants

            //Suit mySuit = Suit.CLUBS;
            //mySuit = Suit.HEARTS;
            //mySuit = Suit.HEARTS;

            //mySuit = (Suit)99;
            //int diamonds = (int)Suit.DIAMONDS;
            //Console.WriteLine(diamonds);

            //string userInput = Console.ReadLine();

            //mySuit = (Suit)Enum.Parse(typeof(Suit), userInput);

            #endregion

            var builder = new StringBuilder("hello");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            builder.Append("looooo");
            Console.WriteLine(builder);

        }




        #region (inefficient) string manipulation
        public static string newString(string myString)
        {
            #region method requirements
            /*Trim off any leading or trailing spaces from myString. Turn all the characters to Upper Case
            Replace all occurances of the letters 'L' and 'T' with '*'
            Find the index of the letter 'N', and delete all the characters after it
             Return the result*/
            #endregion
            string result = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');

            int index = result.IndexOf('N');
            return result.Substring(0, index + 1);
            #region Note
            //This method produces 6 strings in total behind the scenes,
            //which can cause memory (?) issues
            //Strings are IMMUTABLE.
            //Every time it seems to be altered,
            //a new copy is made. This is mitigated by StringBuilder method below
            #endregion


        }
        #endregion
        #region StringBuilder
        private static string StringBuilderExercise(string myString)
        {
            string modded = "hello";
           
            var sb = new StringBuilder(modded);

            sb.Replace('T', '*').Replace('L', '*');
            return sb.ToString() ;
        }
        #endregion

    }
}