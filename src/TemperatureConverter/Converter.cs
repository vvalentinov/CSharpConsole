namespace TemperatureConverter
{
    public static class Converter
    {
        public static double CelsiusToFahrenheit(int celsius) => (celsius * 1.8) + 32;

        public static double CelsiusToKelvin(int celsius) => celsius + 273.15;

        public static double FahrenheitToCelsius(int fahrenheit) => (fahrenheit - 32) * (5 / 9 * 1.0);

        public static double FahrenheitToKelvin(int fahrenheit) => (fahrenheit - 32) * (5 / 9 * 1.0) + 273.15;

        public static double KelvinToCelsius(int kelvin) => kelvin - 273.15;

        public static double KelvinToFahrenheit(int kelvin) => (kelvin - 273.15) * 1.8 + 32;
    }
}
