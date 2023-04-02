using System.Xml.Serialization;

// VALUE TYPES: Integral numerals, Floating point numbers, Booleans, Chars
// VALUE TYPES are stored on the STACK

// OBJECT TYPES: Random, Objects, etc
// OBJECT TYPES are stored on the HEAP

//STRING: 


namespace MemoryModelLESSON
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s1 = "string";
            string s2 = "string";
            string s3 = "string1";

            Console.WriteLine(Object.ReferenceEquals(s1, s2)); // True
            Console.WriteLine(Object.ReferenceEquals(s1, s3)); // False

            int x = 1;
            int y = 1;

            Console.WriteLine(Object.ReferenceEquals(x, y));

            int i = 10;
            string s = "example";
            { 
                i = 12;
                s = "CHANGED";
            }
            





            //Some types are "value" types, some are "reference" types
            //Value types are copied, referenced types are not.

            int n = 10;
            int[] arrr = { -9, -8, -7 }; //arrays are reference types. they live on heap

            PassByRefDemo(ref n, arrr);
        }

        //int passed in is copied, but the array passed is altered

        ///ref keyword changes original int
        private static void PassByRefDemo(ref int intArg, int[] arrArg)
        {
            int[] arrCopy = new int[arrArg.Length];// makinga a  copy to avoid altering arrArg

            intArg /= 2;
            for(int i = 0; i < arrArg.Length; i++)
            {
               // arrArg[i] = Math.Abs(arrArg[i]); This would've changed original argument. Arrays stored in heap

                arrCopy[i] = Math.Abs(arrArg[i]); 
            }
        }
    }
}