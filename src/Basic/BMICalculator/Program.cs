using BMICalculator;

Console.WriteLine("Welcome to the BMI Calculator!");

ConsolePrinter.PrintEnterWeightMessage();

string weightInput = Console.ReadLine() ?? string.Empty;
while (!Validator.IsWeightInputValid(weightInput))
{
    ConsolePrinter.PrintError();
    ConsolePrinter.PrintEnterWeightMessage();
    weightInput = Console.ReadLine() ?? string.Empty;
}

Console.WriteLine();

int weight = int.Parse(weightInput);

Console.WriteLine("Next step is for you to enter your height in meters and centimeters.");
Console.WriteLine("First you will enter your meters and after that your centimeters.");

ConsolePrinter.PrintEnterMetersMessage();

string metersInput = Console.ReadLine() ?? string.Empty;
while (!Validator.IsMetersInputValid(metersInput))
{
    ConsolePrinter.PrintError();
    ConsolePrinter.PrintEnterMetersMessage();
    metersInput = Console.ReadLine() ?? string.Empty;
}

Console.WriteLine();

int meters = int.Parse(metersInput);

ConsolePrinter.PrintEnterCentimetersMessage();

string centimetersInput = Console.ReadLine() ?? string.Empty;
while (!Validator.IsCentimetersInputValid(centimetersInput))
{
    ConsolePrinter.PrintError();
    ConsolePrinter.PrintEnterCentimetersMessage();
    centimetersInput = Console.ReadLine() ?? string.Empty;
}

int centimeters = int.Parse(centimetersInput);

double bmi = weight / Math.Pow(meters + centimeters * 1.0 / 100, 2);

ConsolePrinter.PrintDashedLine();
ConsolePrinter.PrintBMIResult(bmi);