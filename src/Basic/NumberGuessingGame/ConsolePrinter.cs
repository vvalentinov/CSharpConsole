namespace NumberGuessingGame
{
    public static class ConsolePrinter
    {
        public static void PrintError(string errMessage)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(errMessage);
            Console.ResetColor();
        }

        public static void PrintWarning(string warningMessage)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(warningMessage);
            Console.ResetColor();
        }

        public static void PrintSuccess(string successMessage)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(successMessage);
            Console.ResetColor();
        }

        public static void PrintHelloMessage(int minBoundDifference)
        {
            Console.WriteLine("Welcome To The Number Guessing Game!");
            Console.WriteLine("You can choose the lower and upper bound yourself.");
            Console.WriteLine("The default lower and upper bounds are: 0 to 100 000.");
            PrintWarning($"The difference between the bounds must be at least {minBoundDifference}.");
        }

        public static void PrintQuitMessage(int guessesCount, int randomNumber)
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"We got a quitter here, huh? You quit after {guessesCount} tries.");
            Console.WriteLine($"The generated number was: {randomNumber}.");
        }

        public static void PrintNewLine() => Console.Write(Environment.NewLine);

        public static void PrintEndGameSuccessMessage(int guessesCount)
        {
            if (guessesCount <= 5)
            {
                PrintSuccess($"Amazing job! You guessed it in just {guessesCount} tries. You're a genius!");
            }
            else if (guessesCount <= 10)
            {
                PrintSuccess($"Well done! It only took you {guessesCount} attempts. You're on the right track!");
            }
            else if (guessesCount <= 15)
            {
                PrintSuccess($"Not bad, but there's room for improvement. It took you {guessesCount} tries. Keep practicing!");
            }
            else if (guessesCount <= 20)
            {
                PrintSuccess($"You're average. You need to buckle up and focus! It took you {guessesCount} attempts.");
            }
            else
            {
                PrintSuccess($"Oof! That took a while—{guessesCount} tries to be exact. Don't give up, keep learning!");
            }
        }
    }
}
