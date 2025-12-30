using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{

    public delegate int MathOperation(int a, int b);

    internal class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int multiply(int a, int b)
        {
            return a * b;
        }

        private static int divide(int a, int b)
        {
            return a / b;
        }

        private static int substraction(int a, int b)
        {
            return a - b;
        }

        public static void PerformOperation(int x, int y, MathOperation operation)
        {
            int result = operation(x, y);
            Console.WriteLine($"Result: {result}");
        }

        public static void Main(string[] args)
        {

            PerformOperation(5, 7, Add);
            PerformOperation(5, 7, multiply);
            PerformOperation(5, 7, divide);
            PerformOperation(5, 7, substraction);
        }

        
    }
}
