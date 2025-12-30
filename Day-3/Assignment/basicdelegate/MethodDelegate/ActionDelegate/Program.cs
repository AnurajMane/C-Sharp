class ActionExample
{
    static void Main()
    {
        // Action with no parameters
        Action greet = () => Console.WriteLine("Hello!");
        greet();

        // Action with 1 parameter
        Action<string> sayName = name =>
            Console.WriteLine($"My name is {name}");
        sayName("Alice");

        // Action with 2 parameters
        Action<int, int> printSum = (a, b) =>
            Console.WriteLine($"{a} + {b} = {a + b}");
        printSum(5, 3);

        // Using Action as parameter
        ExecuteAction(() => Console.WriteLine("Executing action!"));
    }

    static void ExecuteAction(Action action)
    {
        Console.WriteLine("Before action");
        action();
        Console.WriteLine("After action");
    }
}