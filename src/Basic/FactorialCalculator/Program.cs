Console.WriteLine("Welcome to the Factorial Calculator Project!");

Console.WriteLine("Enter your non-negative integer below.");
Console.Write("Number: ");

string numberInput = Console.ReadLine() ?? string.Empty;
bool isNumberValid = int.TryParse(numberInput, out int number) && number >= 0;

while (isNumberValid == false)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("The input you've entered is invalid! Try, again.");
    Console.WriteLine();
    Console.ResetColor();
    Console.WriteLine("Enter your non-negative integer below.");
    Console.Write("Number: ");
    numberInput = Console.ReadLine() ?? string.Empty;
    isNumberValid = int.TryParse(numberInput, out number) && number >= 0;
}

Console.WriteLine(new string('-', 50));

int result = 1;

for (int i = 2; i <= number; i++)
{
    result *= i;
}

Console.WriteLine($"Result: {number}! = {result}");