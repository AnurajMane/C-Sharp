public delegate void NotifyDelegate(string message);

class MulticastExample
{
    static void SendEmail(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }

    static void SendSMS(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }

    static void LogMessage(string message)
    {
        Console.WriteLine($"Log: {message}");
    }

    static void Main()
    {
        // Create multicast delegate
        NotifyDelegate notify = SendEmail;
        notify += SendSMS;      // Add another method
        notify += LogMessage;   // Add third method

        // Call all methods at once
        notify("System Alert!");

        Console.WriteLine("\n--- Removing SMS ---\n");

        // Remove a method
        notify -= SendSMS;
        notify("Second Alert!");
    }
}