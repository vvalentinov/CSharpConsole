namespace PasswordGenerator
{
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
    }
}
