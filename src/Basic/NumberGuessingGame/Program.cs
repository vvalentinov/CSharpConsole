using System.Security.Cryptography;
using static NumberGuessingGame.ConsoleReader;
using static NumberGuessingGame.ConsolePrinter;

const int MinBoundDifference = 100;

Console.WriteLine("Welcome To The Number Guessing Game!");
Console.WriteLine("You can choose the lower and upper bound yourself.");
Console.WriteLine("The default lower and upper bounds are: 0 to 100 000.");
PrintWarning($"The difference between the bounds must be at least {MinBoundDifference}.");

int lowerBound = 0;
int upperBound = 100_000;
int guessesCount = 0;

string userBoundsAnswer = GetUserBoundsChoice();

if (userBoundsAnswer == "yes")
{
    int maxLowerBoundValue = int.MaxValue - MinBoundDifference;
    lowerBound = GetUserLowerBound(maxLowerBoundValue);
    
    if (lowerBound == maxLowerBoundValue)
    {
        upperBound = int.MaxValue;
        PrintWarning($"Since you chose {maxLowerBoundValue} for your lower bound value, the upper bound value is {int.MaxValue}");
    }
    else
    {
        upperBound = GetUserUpperBound(lowerBound);
    }
}

int randomNumber = RandomNumberGenerator.GetInt32(lowerBound, upperBound);

PrintSuccess("The random number has been generated! Let the game begin!");
Console.WriteLine("Anytime you want to stop the game just type 'end'.");

bool isGameOver = false;
bool hasGuessedIt = false;

while (isGameOver == false)
{
    Console.Write("Your guess: ");

    string userGuessInput = Console.ReadLine() ?? string.Empty;

    if (userGuessInput == "end")
    {
        break;
    }

    bool isUserGuessValid = int.TryParse(userGuessInput, out int userGuess) &&
        userGuess >= lowerBound &&
        userGuess <= upperBound;

    while (isUserGuessValid == false)
    {
        PrintError($"You must enter a valid number between {lowerBound} and {upperBound}. That guess will not count. Try, again.");
        Console.Write("Your guess: ");
        userGuessInput = Console.ReadLine() ?? string.Empty;
        isUserGuessValid = int.TryParse(userGuessInput, out userGuess) &&
            userGuess >= lowerBound &&
            userGuess <= upperBound;
    }

    guessesCount++;

    if (userGuess == randomNumber)
    {
        isGameOver = true;
        hasGuessedIt = true;
        continue;
    }
    else if (userGuess < randomNumber)
    {
        PrintError("Noo, look's like a hit and a miss!");
        PrintWarning("You will have to go higher than that.");
    }
    else
    {
        PrintError("Noo, look's like a hit and a miss!");
        PrintWarning("You will have to go lower than that.");
    }
}

if (hasGuessedIt)
{
    PrintEndGameSuccessMessage(guessesCount);
}
else
{
    PrintQuitMessage(guessesCount, randomNumber);
}