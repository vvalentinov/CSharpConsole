Console.WriteLine("Welcome to the Prime Checker Project!");
Console.Write("Number: ");

string input = Console.ReadLine() ?? string.Empty;
bool isValidNumber = int.TryParse(input, out int number);
while (!isValidNumber)
{
    Console.WriteLine("You must type a valid number!");
    Console.Write("Number: ");
    input = Console.ReadLine() ?? string.Empty;
    isValidNumber = int.TryParse(input, out number);
}

bool isPrime = true;

if (number <= 1)
{
    isPrime = false;
}
else
{
    int limit = (int)Math.Sqrt(number);

    for (int i = 2; i <= limit; i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
}

Console.WriteLine(isPrime ?
    $"The entered number {number} Is A prime number!" :
    $"The entered number {number} Is Not a prime number!");