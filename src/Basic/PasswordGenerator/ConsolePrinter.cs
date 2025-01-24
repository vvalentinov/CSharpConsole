namespace PasswordGenerator
{
    public static class ConsolePrinter
    {
        public static void PrintChooseLengthMessage()
        {
            Console.WriteLine("Choose length between 5 and 100 characters!");
            Console.Write("Length: ");
        }

        public static void PrintChooseCharactersMessage(string charactersName, string characters)
        {
            Console.WriteLine($"Would you like your password to contain {charactersName} characters: {characters} ?");
            Console.Write("Type 'yes' or 'no': ");
        }

        public static void PrintErrorMessage(string message)
        {
            var currColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = currColor;
        }
    }
}
