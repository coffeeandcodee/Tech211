using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            string result = "";


            for (int i = 0; i < num; i++)
            {
                if (queue.Count == 0) continue;
                if (i > 0) result += ", ";
                result += queue.Dequeue();
            }


            return result;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            throw new NotImplementedException();
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            string result = "";
            Dictionary<int, int> dict = new Dictionary<int, int>() { };

            foreach (char c in input)
            {
                //char - '0' converts characters (even letters) into ints
                int possibleInt = c - '0';
                if (possibleInt.GetType() == typeof(int) && possibleInt < 10)
                {
                    if (!dict.ContainsKey(possibleInt)) dict[possibleInt] = 1;
                    else dict[possibleInt]++;

                }
            }
            foreach(KeyValuePair<int, int> entry in dict)
            {
                result += entry;
            }

            return result;
        }
    }
}
