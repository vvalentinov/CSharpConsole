using static TemperatureConverter.Converter;

Console.WriteLine("Welcome to your temperature converter!");
Console.WriteLine("Choose your converter!");
Console.WriteLine("Your options:");
Console.WriteLine("A: Celsius -> Fahrenheit");
Console.WriteLine("B: Celsius -> Kelvin");
Console.WriteLine("C: Fahrenheit -> Celsius");
Console.WriteLine("D: Fahrenheit -> Kelvin");
Console.WriteLine("E: Kelvin -> Celsius");
Console.WriteLine("F: Kelvin -> Fahrenheit");
Console.WriteLine("Choose one of the options: A, B , C ...");
Console.Write("Option: ");

string converterType = Console.ReadLine() ?? string.Empty;

while (
    converterType != "A" &&
    converterType != "B" &&
    converterType != "C" &&
    converterType != "D" &&
    converterType != "E" &&
    converterType != "F")
{
    Console.WriteLine("Error: You must choose one of the provided options! Try, again!");
    Console.Write("Option: ");
    converterType = Console.ReadLine() ?? string.Empty;
}

Console.Write("Enter temperature value: ");

string tempValueInput = Console.ReadLine() ?? string.Empty;

bool isNumber = double.TryParse(tempValueInput, out double tempValue);

while (!isNumber)
{
    Console.WriteLine("Error: The input is not correct! Try, again!");
    Console.Write("Enter value: ");
    tempValueInput = Console.ReadLine() ?? string.Empty;
    isNumber = double.TryParse(tempValueInput, out tempValue);
}

double result = 0;

switch (converterType)
{
    case "A":
        result = CelsiusToFahrenheit(tempValue);
        break;
    case "B":
        result = CelsiusToKelvin(tempValue);
        break;
    case "C":
        result = FahrenheitToCelsius(tempValue);
        break;
    case "D":
        result = FahrenheitToKelvin(tempValue);
        break;
    case "E":
        result = KelvinToCelsius(tempValue);
        break;
    case "F":
        result = KelvinToFahrenheit(tempValue);
        break;
}

Console.WriteLine(new string('-', 100));
Console.WriteLine($"Result: {result}");