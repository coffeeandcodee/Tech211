using System.Text;

namespace FizzBuzzApp
{   
    //Test Driven Development excercise
    public class Program
    {
        public static string FizzBuzz(int number)
        {
            if (number == 0) return "";

            // StringBuilder result = new StringBuilder("");
            string result = "";
            for(int i = 1; i <= number; i++)
            {
                // result.Append(i + " ");

                if (i % 3 == 0 && i % 5 == 0)
                    result += "FizzBuzz ";
                else if (i % 3 == 0)
                    result += "Fizz ";
                else if (i % 5 == 0)
                    result += "Buzz ";
                else result += i + " ";
            }  
      
            return result.Trim();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}