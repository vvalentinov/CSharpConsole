namespace PasswordGenerator
{
    using System.Numerics;
    using System.Text.RegularExpressions;

    public static class Validator
    {
        public static (bool isLengthValid, string validateLengthMsg) ValidateLength(string input)
        {
            if (!BigInteger.TryParse(input, out BigInteger number))
            {
                return (false, "Error: The input is not a valid number!");
            }

            if (number > long.MaxValue)
            {
                return (false, "Error: The number is too big!");
            }

            if (number < 5 || number > 100)
            {
                return (false, "Error: The character count must be between 5 and 100!");
            }

            return (true, "Valid");
        }

        public static (bool isInputOptionsValid, string validateInputOptionsMsg) ValidateInputOptions(string inputOptions)
        {
            var regex = new Regex("^(U|L|N|S)( (U|L|N|S)){0,3}$|^(U|L|N|S) (U|L|N|S) (U|L|N|S) (U|L|N|S)$");

            if (!regex.IsMatch(inputOptions))
            {
                return (false, "Error: The input characters options were not in correct format!");
            }

            return (true, "Valid");
        }
    }
}
