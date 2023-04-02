using System.Xml.Serialization;

namespace MemoryModelLESSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            string s = "This is a string";
            int[] arr = { };
            Console.WriteLine("Hello, World!");

            {
                //remember strings are IMMUTABLE



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