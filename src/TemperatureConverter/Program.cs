using System.Text;
using static TemperatureConverter.Converter;

Console.WriteLine("Welcome to your temperature converter!");
Console.WriteLine("What type of temperature would you like to convert?");
Console.WriteLine("Your options:");
Console.WriteLine("C - Celsius");
Console.WriteLine("F - Fahrenheit");
Console.WriteLine("K - Kelvin");
Console.Write("Option: ");

string fromTempType = Console.ReadLine() ?? string.Empty;

while (fromTempType != "C" && fromTempType != "K" && fromTempType != "F")
{
    Console.WriteLine("Error: You must choose either C, F or K! Try, again!");
    Console.Write("Option: ");
    fromTempType = Console.ReadLine() ?? string.Empty;
}

Console.Write("Enter value: ");

string inputValue = Console.ReadLine() ?? string.Empty;

bool isNumber = int.TryParse(inputValue, out int fromValue);

while (!isNumber)
{
    Console.WriteLine("Error: The input is not correct! Try, again!");
    Console.Write("Enter value: ");
    inputValue = Console.ReadLine() ?? string.Empty;
    isNumber = int.TryParse(inputValue, out fromValue);
}

StringBuilder toTempOptions = new StringBuilder();

var toTempOptionsList = new List<string>();

switch (fromTempType)
{
    case "C":
        toTempOptions.AppendLine("F - Farenheit");
        toTempOptions.Append("K - Kelvin");
        toTempOptionsList.Add("F");
        toTempOptionsList.Add("K");
        break;
    case "F":
        toTempOptions.AppendLine("C - Celsius");
        toTempOptions.Append("K - Kelvin");
        toTempOptionsList.Add("C");
        toTempOptionsList.Add("K");
        break;
    case "K":
        toTempOptions.AppendLine("C - Celsius");
        toTempOptions.Append("F - Farenheit");
        toTempOptionsList.Add("C");
        toTempOptionsList.Add("F");
        break;
}

Console.WriteLine("To what type of temperature would you like to convert your choice?");
Console.WriteLine("Your options:");
Console.WriteLine(toTempOptions);
Console.Write("Option: ");

string toTempType = Console.ReadLine() ?? string.Empty;

while (!toTempOptionsList.Contains(toTempType))
{
    Console.WriteLine($"Error: Invalid choice for temperature! Valid choices: {string.Join(", ", toTempOptionsList)}! Try, again!");
    Console.Write("Option: ");
    toTempType = Console.ReadLine() ?? string.Empty;
}

double result = 0;

if (fromTempType == "C" && toTempType == "F")
{
    result = CelsiusToFahrenheit(fromValue);
}
else if (fromTempType == "C" && toTempType == "K")
{
    result = CelsiusToKelvin(fromValue);
}
else if (fromTempType == "F" && toTempType == "C")
{
    result = FahrenheitToCelsius(fromValue);
}
else if (fromTempType == "F" && toTempType == "K")
{
    result = FahrenheitToKelvin(fromValue);
}
else if (fromTempType == "K" && toTempType == "C")
{
    result = KelvinToCelsius(fromValue);
}
else if (fromTempType == "K" && toTempType == "F")
{
    result = KelvinToFahrenheit(fromValue);
}

Console.WriteLine($"Result: {result}");