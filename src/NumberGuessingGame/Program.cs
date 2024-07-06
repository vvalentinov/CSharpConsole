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
        Console.WriteLine(isLowerBoundValidMsg);
        Console.Write("Lower bound: ");
        lowerBoundInput = Console.ReadLine() ?? string.Empty;
        (isLowerBoundValid, isLowerBoundValidMsg) = ValidateLowerBound(lowerBoundInput);
    }

    lowerBound = int.Parse(lowerBoundInput);
}