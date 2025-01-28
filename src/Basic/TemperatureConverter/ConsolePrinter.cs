namespace TemperatureConverter
{
    public static class ConsolePrinter
    {
        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintConverterOptions()
        {
            Console.WriteLine("Your options:");
            Console.WriteLine("A: Celsius --> Fahrenheit");
            Console.WriteLine("B: Celsius --> Kelvin");
            Console.WriteLine("C: Fahrenheit --> Celsius");
            Console.WriteLine("D: Fahrenheit --> Kelvin");
            Console.WriteLine("E: Kelvin --> Celsius");
            Console.WriteLine("F: Kelvin --> Fahrenheit");
        }

        public static void PrintNewLine() => Console.Write(Environment.NewLine);
    }
}
