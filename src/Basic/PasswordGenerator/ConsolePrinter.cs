namespace PasswordGenerator
{
    public static class ConsolePrinter
    {
        public static void PrintChooseCharactersMessage(string charactersName, string characters)
            => Console.WriteLine($"Would you like your password to contain {charactersName} characters: {characters} ?");

        public static void PrintErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void PrintNewLine() => Console.Write(Environment.NewLine);
    }
}
