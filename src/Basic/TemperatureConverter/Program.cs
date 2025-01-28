using static TemperatureConverter.Converter;
using static TemperatureConverter.ConsolePrinter;

string[] validConverterTypes = ["a", "b", "c", "d", "e", "f"];

Console.WriteLine("Welcome to your temperature converter!");
Console.WriteLine("Choose your converter!");
PrintNewLine();
PrintConverterOptions();
Console.WriteLine("Type one of the options: A, B , C ...");
Console.Write("Option: ");

string converterType = Console.ReadLine()?.ToLower() ?? string.Empty;

while (validConverterTypes.Contains(converterType) == false)
{
    PrintError("You must choose one of the provided options! Try, again!");
    PrintNewLine();
    PrintConverterOptions();
    Console.Write("Option: ");
    converterType = Console.ReadLine()?.ToLower() ?? string.Empty;
}

PrintNewLine();
Console.Write("Enter temperature value: ");

string tempValueInput = Console.ReadLine() ?? string.Empty;

bool isValid = double.TryParse(tempValueInput, out double tempValue);
while (isValid == false)
{
    PrintError("The input is not correct! Try, again!");
    Console.Write("Enter value: ");
    tempValueInput = Console.ReadLine() ?? string.Empty;
    isValid = double.TryParse(tempValueInput, out tempValue);
}

Console.WriteLine(new string('-', 100));

switch (converterType)
{
    case "a":
        Console.WriteLine($"Result: {CelsiusToFahrenheit(tempValue)}");
        break;
    case "b":
        Console.WriteLine($"Result: {CelsiusToKelvin(tempValue)}");
        break;
    case "c":
        Console.WriteLine($"Result: {FahrenheitToCelsius(tempValue)}");
        break;
    case "d":
        Console.WriteLine($"Result: {FahrenheitToKelvin(tempValue)}");
        break;
    case "e":
        Console.WriteLine($"Result: {KelvinToCelsius(tempValue)}");
        break;
    case "f":
        Console.WriteLine($"Result: {KelvinToFahrenheit(tempValue)}");
        break;
}