using System;

public delegate void GreetDelegate(string message);

class DelegateBasics
{
    public static void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public static void SayGoodbye(string name)
    {
        Console.WriteLine($"Goodbye, {name}!");
    }

    public static void Main(string[] args)
    {
        GreetDelegate greet = SayHello;

        greet("Alice"); 

        greet = SayGoodbye;

        greet("Bob");
    }
}