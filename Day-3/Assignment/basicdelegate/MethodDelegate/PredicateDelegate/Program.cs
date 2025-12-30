class PredicateExample
{
    static void Main()
    {
        // Predicate to check if number is even
        Predicate<int> isEven = num => num % 2 == 0;
        Console.WriteLine($"Is 4 even? {isEven(4)}");
        Console.WriteLine($"Is 7 even? {isEven(7)}");

        // Predicate to check string length
        Predicate<string> isLongString = str => str.Length > 5;
        Console.WriteLine($"Is 'Hello' long? {isLongString("Hello")}");
        Console.WriteLine($"Is 'Programming' long? {isLongString("Programming")}");

        // Using Predicate to filter
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] evenNumbers = Filter(numbers, isEven);
        Console.WriteLine($"Even numbers: {string.Join(", ", evenNumbers)}");
    }

    static int[] Filter(int[] arr, Predicate<int> condition)
    {
        var result = new System.Collections.Generic.List<int>();
        foreach (int item in arr)
            if (condition(item))
                result.Add(item);
        return result.ToArray();
    }
}