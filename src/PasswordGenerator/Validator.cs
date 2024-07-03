namespace PasswordGenerator
{
    using System.Text.RegularExpressions;
    using static PasswordGenerator.ConsolePrinter;

    public static class Validator
    {
        public static int ValidateLength(string input)
        {
            bool isNumber = int.TryParse(input, out int length);

            while (!isNumber || length < 5 || length > 100)
            {
                Console.WriteLine("Error! Try, again!");

                PrintChooseLengthMessage();

                isNumber = int.TryParse(Console.ReadLine(), out length);
            }

            return length;
        }

        public static string ValidateInputOptions(string inputOptions)
        {
            var regex = new Regex("^(U|L|N|S)( (U|L|N|S)){0,2}$");

            while (!regex.IsMatch(inputOptions))
            {
                if (string.IsNullOrWhiteSpace(inputOptions))
                {
                    inputOptions = "A";
                    break;
                }

                Console.WriteLine("Error: The input characters options were not in correct format!");

                PrintChooseOptionsMessage();

                inputOptions = Console.ReadLine() ?? string.Empty;
            }

            return inputOptions;
        }
    }
}
