namespace WaterIntake
{
    using System.Globalization;
    using WaterIntake.Data;

    public static class Validator
    {
        public static bool IsUserMenuChoiceValid(string userMenuChoice)
            => byte.TryParse(userMenuChoice, out byte menuChoice) && menuChoice >= 0 && menuChoice <= 4;

        public static bool IsDateInputInValidFormat(string date)
            => DateTime.TryParseExact(
                    date,
                    DbConstants.TableDateColumnFormat,
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime result) && result <= DateTime.UtcNow;

        public static bool IsLitresInputInValid(string litres)
        {
            if (float.TryParse(litres, out float result) && result >= 0)
            {
                var parts = litres.Split('.');

                if (parts.Length == 2 && parts[1].Length > 3)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        public static bool IsRecordIdValidInteger(string recordIdInput)
            => int.TryParse(recordIdInput, out int result) && result >= 0;
    }
}
