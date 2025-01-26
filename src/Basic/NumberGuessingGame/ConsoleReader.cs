namespace NumberGuessingGame
{
    using static NumberGuessingGame.ConsolePrinter;

    public static class ConsoleReader
    {
        public static string GetUserBoundsChoice()
        {
            Console.WriteLine("Would you like to choose the bounds yourself? Type 'yes' or 'no'.");
            Console.Write("Your Answer: ");

            string userBoundsAnswer = Console.ReadLine()?.ToLower() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(userBoundsAnswer))
            {
                return "no";
            }

            while (userBoundsAnswer != "yes" && userBoundsAnswer != "no")
            {
                PrintError("Oops! Look's like you made a mistake with your spelling. Try, again.");
                Console.Write("Your Answer: ");
                userBoundsAnswer = Console.ReadLine()?.ToLower() ?? string.Empty;
            }

            return userBoundsAnswer;
        }

        public static int GetUserLowerBound(int maxLowerBoundValue)
        {
            Console.WriteLine("You will now choose the lower bound.");
            Console.WriteLine($"Type a number between {int.MinValue} and {maxLowerBoundValue}.");
            Console.Write("Lower bound: ");

            string lowerBoundInput = Console.ReadLine() ?? string.Empty;

            bool isLowerBoundValid = int.TryParse(lowerBoundInput, out int lowerBound) && lowerBound <= maxLowerBoundValue;

            while (isLowerBoundValid == false)
            {
                PrintError("Oops! Look's like you chose an invalid value for your lower bound. Try, again.");
                Console.WriteLine($"Type a number between {int.MinValue} and {maxLowerBoundValue}.");
                Console.Write("Lower bound: ");
                lowerBoundInput = Console.ReadLine() ?? string.Empty;
                isLowerBoundValid = int.TryParse(lowerBoundInput, out lowerBound);
            }

            return lowerBound;
        }

        public static int GetUserUpperBound(int lowerBound)
        {
            Console.WriteLine("You will now choose the upper bound.");
            PrintWarning("Keep in mind that the difference between the bounds must be at least 100.");
            Console.WriteLine($"Type a number between {lowerBound} and {int.MaxValue}.");
            Console.Write("Upper bound: ");
            string upperBoundInput = Console.ReadLine() ?? string.Empty;

            bool isUpperBoundValid = int.TryParse(upperBoundInput, out int upperBound) &&
                (upperBound >= lowerBound + 100);

            while (isUpperBoundValid == false)
            {
                PrintError("Oops! Look's like you chose an invalid value for your upper bound. Try, again.");
                Console.WriteLine($"Type a number between {lowerBound} and {int.MaxValue}.");
                PrintWarning("Keep in mind that the difference between the bounds must be at least 100.");
                Console.Write("Upper bound: ");
                upperBoundInput = Console.ReadLine() ?? string.Empty;
                isUpperBoundValid = int.TryParse(upperBoundInput, out upperBound);
            }

            if (upperBound < int.MaxValue)
            {
                upperBound += 1;
            }

            return upperBound;
        }
    }
}
