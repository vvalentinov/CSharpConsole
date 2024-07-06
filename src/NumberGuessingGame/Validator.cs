namespace NumberGuessingGame
{
    using System.Numerics;

    public class Validator
    {
        public static (bool result, string message) ValidateLowerBound(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return (true, "Valid");
            }

            var isParsable = BigInteger.TryParse(input, out BigInteger lowerBoundParseResult);

            if (!isParsable)
            {
                return (false, "Error: You must enter a valid number! Try, again!");
            }

            if (lowerBoundParseResult < 0)
            {
                return (false, "Error: The lower bound cannot be less than zero! Try, again!");
            }

            if (lowerBoundParseResult > int.MaxValue)
            {
                return (false, $"Error: The lower bound cannot be bigger than {int.MaxValue}! Try, again!");
            }

            return (true, "Valid");
        }
    }
}
