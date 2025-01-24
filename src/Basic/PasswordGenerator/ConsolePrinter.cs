namespace PasswordGenerator
{
    public static class ConsolePrinter
    {
        public static void PrintCharacterOptions(IDictionary<char, string> charactersList)
        {
            Console.WriteLine("(Optional) Characters options (default: All):");
            Console.WriteLine($"U - uppercase characters: {charactersList['U']}");
            Console.WriteLine($"L - lowercase characters: {charactersList['L']}");
            Console.WriteLine($"N - numbers: {charactersList['N']}");
            Console.WriteLine($"S - special characters: {charactersList['S']}");
        }

        public static void PrintChooseLengthMessage()
        {
            Console.WriteLine("Choose length between 5 and 100 characters!");
            Console.Write("Length: ");
        }

        public static void PrintChooseOptionsMessage()
            => Console.Write("Choose your options, separated by a space: ");
    }
}
