namespace PasswordGenerator
{
    using static PasswordGenerator.ConsolePrinter;

    public static class ConsoleReader
    {
        public static byte GetPasswordLength()
        {
            byte passLength = 0;
            bool isPassValid = false;

            while (!isPassValid)
            {
                PrintChooseLengthMessage();

                string passLengthInput = Console.ReadLine() ?? string.Empty;
                isPassValid = byte.TryParse(passLengthInput, out passLength) &&
                    passLength >= 5 &&
                    passLength <= 100;

                if (!isPassValid)
                {
                    PrintErrorMessage("Looks like the input you entered was invalid! Try, again!");
                }
            }

            return passLength;
        }

        public static string GetUserYesOrNoChoice()
        {
            string choice = Console.ReadLine()?.ToLower() ?? string.Empty;

            while (choice != "yes" && choice != "no")
            {
                PrintErrorMessage("Oops! Look's like you made a mistake with your spelling! Try, again!");
                Console.Write("Type 'yes' or 'no': ");
                choice = Console.ReadLine()?.ToLower() ?? string.Empty;
            }

            return choice;
        }
    }
}
