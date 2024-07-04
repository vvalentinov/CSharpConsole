namespace TemperatureConverter
{
    public static class Converter
    {
        public static double CelsiusToFahrenheit(double celsius) => (celsius * 1.8) + 32;

        public static double CelsiusToKelvin(double celsius) => celsius + 273.15;

        public static double FahrenheitToCelsius(double fahrenheit) => (fahrenheit - 32) * (5 / 9 * 1.0);

        public static double FahrenheitToKelvin(double fahrenheit) => (fahrenheit - 32) * (5 / 9 * 1.0) + 273.15;

        public static double KelvinToCelsius(double kelvin) => kelvin - 273.15;

        public static double KelvinToFahrenheit(double kelvin) => (kelvin - 273.15) * 1.8 + 32;
    }
}
