namespace NumberGuessingGame
{
    public static class ConsoleReader
    {
        public static string GetUserBoundsChoice()
        {
            Console.Write("Your Answer: ");

            string userBoundsAnswer = Console.ReadLine()?.ToLower() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(userBoundsAnswer))
            {
                return "no";
            }

            return userBoundsAnswer;
        }

        public static string GetUserLowerBound(int maxLowerBoundValue)
        {
            Console.WriteLine($"Type a number between {int.MinValue} and {maxLowerBoundValue}.");
            Console.Write("Lower bound: ");
            return Console.ReadLine() ?? string.Empty;
        }

        public static string GetUserUpperBound(int lowerBound)
        {
            Console.WriteLine($"Type a number between {lowerBound} and {int.MaxValue}.");
            Console.Write("Upper bound: ");
            return Console.ReadLine() ?? string.Empty;
        }

        public static string GetUserNumberGuess()
        {
            Console.Write("Your guess: ");
            return Console.ReadLine()?.ToLower() ?? string.Empty;
        }
    }
}
