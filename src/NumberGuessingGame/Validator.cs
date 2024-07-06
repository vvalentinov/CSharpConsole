namespace NumberGuessingGame
{
    using System.Numerics;

    public static class Validator
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

        public static (bool result, string message) ValidateUpperBound(string input, int lowerBound)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return (true, "Valid");
            }

            var isParsable = BigInteger.TryParse(input, out BigInteger upperBoundParseResult);

            if (!isParsable)
            {
                return (false, "Error: You must enter a valid number! Try, again!");
            }

            if (upperBoundParseResult < 0)
            {
                return (false, "Error: The upper bound cannot be less than zero! Try, again!");
            }

            if (upperBoundParseResult > int.MaxValue)
            {
                return (false, $"Error: The upper bound cannot be bigger than {int.MaxValue}! Try, again!");
            }

            if (upperBoundParseResult <= lowerBound)
            {
                return (false, "Error: The upper bound cannot be less than or equal to the lower bound! Try, again!");
            }

            return (true, "Valid");
        }

        public static (bool result, string message) ValidateGuessedNumber(
            string input,
            int lowerBound,
            int upperBound,
            int randomNumber)
        {
            var isParsable = BigInteger.TryParse(input, out BigInteger number);

            if (!isParsable)
            {
                return (false, "Error: You must enter a valid number! Try, again!");
            }

            if (number < lowerBound || number > upperBound)
            {
                return (false, $"Error: You must enter a number in the specified range: {lowerBound} - {upperBound}! Try, again!");
            }

            if (number < randomNumber)
            {
                return (false, "Error: You'll have to aim higher! Try, again!");
            }

            if (number > randomNumber)
            {
                return (false, "Error: You'll have to aim lower! Try, again!");
            }

            return (true, "Valid");
        }
    }
}
