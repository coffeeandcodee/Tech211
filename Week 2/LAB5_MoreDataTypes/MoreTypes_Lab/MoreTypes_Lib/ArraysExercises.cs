using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            //or contents.toArray(
            int l = contents.Count; 
            var arr = new string[l];

            for(int i = 0; i < contents.Count; i++)
            {
                arr[i] = contents[i];
            }

            return arr;
           
           
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            string[,,] my3DArray = new string[length1, length2, length3];
            
            if(length1 * length2 * length3 != contents.Count)
            {
                throw new ArgumentException("Number of elements in list must match array size");

            }

            /*Initiate index to loop over List seperately*/
            int contentsIndex = 0;
                for (int i = 0; i < length1; i++)
                {
                    for (int j = 0; j < length2; j++)
                    {
                        for (int k = 0; k < length3; k++)
                        {
                        my3DArray[i, j, k] = contents[contentsIndex];
                        contentsIndex++;
                        }
                    }

                }
            
            return my3DArray;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            if(countRow1 + countRow2 != contents.Count)
            {
                throw new ArgumentException("Number of elements in list must match array size");
            }
            string[][] jaggedArray = new string[2][];
            jaggedArray[0] = new string[countRow1];
            jaggedArray[1] = new string[countRow2]; 

            int contentsIndex = 0;
            for (int i = 0; i < countRow1; i++)
            {
                jaggedArray[0][i] = contents[contentsIndex];
                contentsIndex++;

            }
            for (int i = 0; i < countRow2; i++)
            {
                jaggedArray[1][i] = contents[contentsIndex];
                contentsIndex++;

            }
            return jaggedArray;
        }
    }
}
