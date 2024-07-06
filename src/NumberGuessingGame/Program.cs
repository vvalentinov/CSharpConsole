using System.Security.Cryptography;
using static NumberGuessingGame.Validator;

Console.WriteLine("Welcome to the number guessing game!");
Console.WriteLine("(Optional): You can choose lower and upper bound! (default: 0 - 100 000)");

Console.Write("Lower bound: ");

string lowerBoundInput = Console.ReadLine() ?? string.Empty;

int lowerBound = 0;

if (!string.IsNullOrWhiteSpace(lowerBoundInput))
{
    (bool isLowerBoundValid, string isLowerBoundValidMsg) = ValidateLowerBound(lowerBoundInput);

    while (!isLowerBoundValid)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(isLowerBoundValidMsg);
        Console.ResetColor();
        Console.Write("Lower bound: ");
        lowerBoundInput = Console.ReadLine() ?? string.Empty;
        (isLowerBoundValid, isLowerBoundValidMsg) = ValidateLowerBound(lowerBoundInput);
    }

    lowerBound = int.Parse(lowerBoundInput);
}

Console.Write("Upper bound: ");

string upperBoundInput = Console.ReadLine() ?? string.Empty;

int upperBound = 100_000;

if (!string.IsNullOrWhiteSpace(upperBoundInput))
{
    (bool isUpperBoundValid, string isUpperBoundValidMsg) = ValidateUpperBound(upperBoundInput, lowerBound);

    while (!isUpperBoundValid)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(isUpperBoundValidMsg);
        Console.ResetColor();
        Console.Write("Upper bound: ");
        upperBoundInput = Console.ReadLine() ?? string.Empty;
        (isUpperBoundValid, isUpperBoundValidMsg) = ValidateUpperBound(upperBoundInput, lowerBound);
    }

    upperBound = int.Parse(upperBoundInput);
}

int randomNumber = RandomNumberGenerator.GetInt32(lowerBound, upperBound + 1);

Console.WriteLine("The random number has been generated! Let the game begin!");
Console.Write("Your guess: ");

string guessedNumber = Console.ReadLine() ?? string.Empty;

(bool isGuessedNumberValid, string isGuessedNumberValidMsg) = ValidateGuessedNumber(
    guessedNumber,
    lowerBound,
    upperBound,
    randomNumber);

while (!isGuessedNumberValid)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(isGuessedNumberValidMsg);
    Console.ResetColor();
    Console.Write("Your guess: ");

    guessedNumber = Console.ReadLine() ?? string.Empty;

    (isGuessedNumberValid, isGuessedNumberValidMsg) = ValidateGuessedNumber(
        guessedNumber,
        lowerBound,
        upperBound,
        randomNumber);
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Hurray! Look's like the good guys always win at the end!");
Console.ResetColor();