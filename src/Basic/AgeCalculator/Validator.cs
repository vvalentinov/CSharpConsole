namespace AgeCalculator
{
    using System.Globalization;

    public static class Validator
    {
        public static bool IsDateInCorrectFormat(string date)
            => DateTime.TryParseExact(
                    date,
                    Constants.DATE_FORMAT,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime result) && result < DateTime.UtcNow;
    }
}
