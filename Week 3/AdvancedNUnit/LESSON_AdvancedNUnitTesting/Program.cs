﻿using System.Diagnostics.Metrics;

namespace AdvancedNUnit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Calculator
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Add()
        {
            return Num1 + Num2;
        }

        public bool IsDivisible()
        {
            return Num1 % Num2 == 0;
        }



        



    }
    public class Counter
    {
        public int Count { get; private set; }
        public Counter(int start) { Count = start; }
        public void Increment() { Count++; }
        public void Decrement() { Count--; }
    }



}