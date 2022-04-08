public static class Misc
{
    public static void Log(string message, ConsoleColor color = ConsoleColor.Blue)
    {
        var currentColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ForegroundColor = currentColor;
    }
}