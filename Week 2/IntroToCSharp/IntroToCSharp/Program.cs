using System;
using System.Security.Cryptography.X509Certificates;

namespace IntroToCSharp;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Greetings, Universe!!!");
        int x = 100;
        x = x + 10; 
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine("i is: " + i + ", x is" + x);
            x += i;
        }
    }
}





