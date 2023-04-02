using System;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            string result = input.Trim().ToUpper();
            for(int i = 0; i < num; i++)
            {
                result += i;
            }
            return result;

        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            return $"{number} {street}, {city} {postcode}.";
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double percent = Math.Round((double)score / outOf * 100, 1);

            return $"You got {score} out of {outOf}: {percent}%";
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        //Tryparse signature
        /*public static bool TryParse (string? s, out double result);*/

        public static double ParseNum(string numString)
        {
            double number;
            //return Double.TryParse(numString, out number) ? number : -999d;

            return Double.TryParse(numString, out number) ? number : -999d;
            
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int A = 0, B = 0, C = 0, D = 0;

            for(int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case 'A': A++; break;
                    case 'B': B++; break;
                    case 'C': C++; break;
                    case 'D': D++; break;

                }
            }
            return $"A:{A} B:{B} C:{C} D:{D}";
        }
    }
}
