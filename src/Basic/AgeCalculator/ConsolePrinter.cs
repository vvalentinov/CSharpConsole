namespace AgeCalculator
{
    public static class ConsolePrinter
    {
        public static void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintEnterDateMessage()
        {
            Console.WriteLine($"Enter your birthdate in this format: {Constants.DATE_FORMAT}");
            Console.Write("Date: ");
        }

        public static void PrintDashedLine(int length) => Console.WriteLine(new string('-', length));
    }
}
