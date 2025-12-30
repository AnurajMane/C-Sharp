using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    // This class will be shared across multiple applications
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero");
            return (double)a / b;
        }
    }

    public class StringHelper
    {
        public string Reverse(string input)
        {
            char[] chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public bool IsPalindrome(string input)
        {
            string cleaned = input.Replace(" ", "").ToLower();
            return cleaned == Reverse(cleaned);
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            // Use the Calculator class from shared assembly
            Calculator calc = new Calculator();

            Console.WriteLine("=== Using Shared Assembly ===");
            Console.WriteLine($"10 + 5 = {calc.Add(10, 5)}");
            Console.WriteLine($"10 - 5 = {calc.Subtract(10, 5)}");
            Console.WriteLine($"10 * 5 = {calc.Multiply(10, 5)}");
            Console.WriteLine($"10 / 5 = {calc.Divide(10, 5)}");

            // Use the StringHelper class
            StringHelper helper = new StringHelper();

            Console.WriteLine($"\nReverse of 'Hello': {helper.Reverse("Hello")}");
            Console.WriteLine($"Is 'racecar' a palindrome? {helper.IsPalindrome("racecar")}");
        }
    }
}
