using AgeCalculator;
using System.Globalization;

Console.WriteLine("Welcome to the Age Calculator!");
ConsolePrinter.PrintEnterDateMessage();

string userBirthdateInput = Console.ReadLine() ?? string.Empty;

while (Validator.IsDateInCorrectFormat(userBirthdateInput) == false)
{
    ConsolePrinter.PrintError(Constants.InvalidDateInputMessage);
    Console.WriteLine();
    ConsolePrinter.PrintEnterDateMessage();
    userBirthdateInput = Console.ReadLine() ?? string.Empty;
}

var userBirthdate = DateTime.Parse(userBirthdateInput, CultureInfo.InvariantCulture, DateTimeStyles.None);

int years = Calculator.CalcUserYears(userBirthdate);
int months = Calculator.CalcUserMonths(userBirthdate);
int days = Calculator.CalcUserDays(userBirthdate);
int hours = Calculator.CalcUserHours(userBirthdate);
int minutes = Calculator.CalcUserMinutes(userBirthdate);

ConsolePrinter.PrintDashedLine(50);

Console.WriteLine($"You are {years} years old.");
Console.WriteLine($"You are {months} months old.");
Console.WriteLine($"You are {days} days old.");
Console.WriteLine($"You are {hours} hours old.");
Console.WriteLine($"You are {minutes} minutes old.");