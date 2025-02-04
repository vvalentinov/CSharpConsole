Console.WriteLine("Welcome to the Leap Year Checker Project!");
Console.WriteLine("Enter the year you want to check below.");
Console.Write("Year: ");

bool isValidYear = int.TryParse(Console.ReadLine(), out int year);

while (isValidYear == false)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("The input you entered was invalid! Try, again.");
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine("Enter the year you want to check below.");
    Console.Write("Year: ");
    isValidYear = int.TryParse(Console.ReadLine(), out year);
}

// Option 1: Use built in .IsLeapYear(year) method
//bool isLeapYear = DateTime.IsLeapYear(year);

// Option 2:
bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 4 == 0 && year % 100 == 0 && year % 400 == 0);
Console.WriteLine(new string('-', 50));
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(isLeapYear ? $"{year} IS a leap year." : $"{year} is NOT a leap year.");
Console.ResetColor();