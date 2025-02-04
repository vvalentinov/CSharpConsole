namespace BMICalculator
{
    public static class Validator
    {
        public static bool IsMetersInputValid(string metersInput)
            => int.TryParse(metersInput, out int meters) && meters > 0;

        public static bool IsWeightInputValid(string weightInput)
            => int.TryParse(weightInput, out int weight) && weight > 0 && weight < 650;

        public static bool IsCentimetersInputValid(string centimetersInput)
            => int.TryParse(centimetersInput, out int centimeters) && centimeters > 0 && centimeters < 100;
    }
}
