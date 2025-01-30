namespace PasswordGenerator
{
    public static class ConsoleReader
    {
        public static string GetPasswordLength()
        {
            Console.WriteLine("Choose length between 5 and 100 characters!");
            Console.Write("Length: ");
            return Console.ReadLine() ?? string.Empty;
        }

        public static string GetUserYesOrNoChoice()
        {
            Console.Write("Type 'yes' or 'no': ");
            return Console.ReadLine()?.ToLower() ?? string.Empty;
        }
    }
}
