using NumberGuessingGame;
using System.Security.Cryptography;

const int MinBoundDifference = 100;

ConsolePrinter.PrintHelloMessage(MinBoundDifference);

int guessesCount = 0;

int lowerBound = 0;
int upperBound = 100_000;

Console.WriteLine("Would you like to choose the bounds yourself? Type 'yes' or 'no'.");

string userBoundsAnswer = ConsoleReader.GetUserBoundsChoice();

bool isUserBoundsAnswerValid = Validator.IsUserBoundsChoiceValid(userBoundsAnswer);
while (isUserBoundsAnswerValid == false)
{
    ConsolePrinter.PrintError("Oops! Look's like you made a mistake with your spelling. Try, again.");
    ConsolePrinter.PrintNewLine();
    userBoundsAnswer = ConsoleReader.GetUserBoundsChoice();
    isUserBoundsAnswerValid = Validator.IsUserBoundsChoiceValid(userBoundsAnswer);
}

if (userBoundsAnswer == "yes")
{
    int maxLowerBoundValue = int.MaxValue - MinBoundDifference;

    Console.WriteLine("You will now choose the lower bound.");

    string lowerBoundInput = ConsoleReader.GetUserLowerBound(maxLowerBoundValue);

    bool isLowerBoundValid = Validator.IsLowerBoundValid(lowerBoundInput, maxLowerBoundValue);
    while (isLowerBoundValid == false)
    {
        ConsolePrinter.PrintError("Oops! Look's like you chose an invalid value for your lower bound. Try, again.");
        ConsolePrinter.PrintNewLine();
        lowerBoundInput = ConsoleReader.GetUserLowerBound(maxLowerBoundValue);
        isLowerBoundValid = Validator.IsLowerBoundValid(lowerBoundInput, maxLowerBoundValue);
    }

    lowerBound = int.Parse(lowerBoundInput);

    if (lowerBound == maxLowerBoundValue)
    {
        upperBound = int.MaxValue;
        ConsolePrinter.PrintWarning($"Since you chose {maxLowerBoundValue} for your lower bound value, the upper bound value is {int.MaxValue}");
    }
    else
    {
        Console.WriteLine("You will now choose the upper bound.");
        ConsolePrinter.PrintWarning($"Keep in mind that the difference between the bounds must be at least {MinBoundDifference}.");

        string upperBoundInput = ConsoleReader.GetUserUpperBound(lowerBound);

        bool isUpperBoundValid = Validator.IsUpperBoundValid(upperBoundInput, lowerBound);
        while (isUpperBoundValid == false)
        {
            ConsolePrinter.PrintError("Oops! Look's like you chose an invalid value for your upper bound. Try, again.");
            ConsolePrinter.PrintNewLine();
            upperBoundInput = ConsoleReader.GetUserUpperBound(lowerBound);
            isUpperBoundValid = Validator.IsUpperBoundValid(upperBoundInput, lowerBound);
        }

        upperBound = int.Parse(upperBoundInput);

        if (upperBound < int.MaxValue)
        {
            upperBound += 1;
        }
    }
}

int randomNumber = RandomNumberGenerator.GetInt32(lowerBound, upperBound);

ConsolePrinter.PrintSuccess("The random number has been generated! Let the game begin!");
Console.WriteLine("Anytime you want to stop the game just type 'end'.");

bool hasUserGuessedIt = false;
while (hasUserGuessedIt == false)
{
    string userGuessInput = ConsoleReader.GetUserNumberGuess();

    if (userGuessInput == "end")
    {
        break;
    }

    bool isUserGuessValid = Validator.IsUserGuessValid(userGuessInput, lowerBound, upperBound);
    while (isUserGuessValid == false)
    {
        ConsolePrinter.PrintError($"You must enter a valid number between {lowerBound} and {upperBound}. That guess will not count. Try, again.");
        userGuessInput = ConsoleReader.GetUserNumberGuess();
        isUserGuessValid = Validator.IsUserGuessValid(userGuessInput, lowerBound, upperBound);
    }

    guessesCount++;

    int userGuess = int.Parse(userGuessInput);

    if (userGuess == randomNumber)
    {
        hasUserGuessedIt = true;
        break;
    }

    ConsolePrinter.PrintError("Noo, look's like a hit and a miss!");
    ConsolePrinter.PrintWarning(userGuess < randomNumber ?
        "You will have to go higher than that." :
        "You will have to go lower than that.");
}

if (hasUserGuessedIt)
{
    ConsolePrinter.PrintEndGameSuccessMessage(guessesCount);
}
else
{
    ConsolePrinter.PrintQuitMessage(guessesCount, randomNumber);
}