namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("6 factorial is 720");
            Console.WriteLine(GetFactorialRecursively(6));


            Console.WriteLine(Fibonnaci(7));

        }

        private static int GetFactorial(int n)
        {
            int sum = 1;
            for(int i = 1; i <= n; i++)
            {
                sum *= i;
            }

            return sum;
        }

        private static int GetFactorialRecursively(int n)
        {
            //0! is 1 remember
            if (n <= 1) return 1;
            return n * GetFactorialRecursively(n - 1);
        }

        private static int[] FibonnaciArray(int n)
        {
            int[] result = new int[n]; 
            if(n == 1)
            {
                result[0] = 0;
            }
            if(n == 2)
            {
                result[0] = 0;
                result[1] = 1;

            }
            FibonnaciArray(n - 1);


            return result;

        }

        private static int Fibonnaci(int n)
        {
            if (n == 1) return 0;
            if (n == 2) return 1;

            return Fibonnaci(n - 1) + Fibonnaci(n - 2); 
        }
    }
}