class FuncExample
{
    static void Main()
    {
        // Func with no parameters, returns int
        Func<int> getRandomNumber = () => new Random().Next(1, 100);
        Console.WriteLine($"Random: {getRandomNumber()}");

        // Func with 2 parameters, returns int
        Func<int, int, int> add = (x, y) => x + y;
        Console.WriteLine($"Sum: {add(10, 20)}");

        // Func with string parameter, returns int
        Func<string, int> getLength = str => str.Length;
        Console.WriteLine($"Length: {getLength("Hello")}");

        // Using Func to transform data
        int[] numbers = { 1, 2, 3, 4, 5 };
        int[] doubled = Transform(numbers, x => x * 2);
        Console.WriteLine($"Doubled: {string.Join(", ", doubled)}");
    }

    static int[] Transform(int[] arr, Func<int, int> transformer)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            result[i] = transformer(arr[i]);
        return result;
    }
}