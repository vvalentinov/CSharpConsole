namespace WaterIntake
{
    using System.Globalization;

    using static WaterIntake.DbConstants;
    using static WaterIntake.ConsolePrinter;

    public static class ConsoleReader
    {
        public static decimal GetLitresInput(bool isForUpdate = false)
        {
            string message = isForUpdate ?
                "Insert litres quantity. (Type Enter to remain unchanged!)" :
                "Insert litres quantity. Type 0 to abort and return to Menu!";

            Console.WriteLine(message);
            PrintLitresInputMessage();

            string numberInput = Console.ReadLine();

            if (isForUpdate && string.IsNullOrWhiteSpace(numberInput))
            {
                return 0;
            }

            if (!isForUpdate && numberInput == "0")
            {
                Console.WriteLine();
                return 0;
            }

            bool isValid =
                decimal.TryParse(numberInput, out decimal litres) &&
                litres > 0;

            while (!isValid)
            {
                PrintInvalidLitresInputError();
                PrintLitresInputMessage();

                numberInput = Console.ReadLine();

                if (isForUpdate && string.IsNullOrWhiteSpace(numberInput))
                {
                    return 0;
                }

                if (!isForUpdate && numberInput == "0")
                {
                    Console.WriteLine();
                    return 0;
                }

                isValid = decimal.TryParse(numberInput, out litres) && litres > 0;
            }

            return litres;
        }

        public static string GetDateInput(bool isForUpdate = false)
        {
            string message = isForUpdate ?
                "Insert the date: (Format: dd.MM.yyyy). (Type Enter to remain unchanged!)" :
                "Insert the date: (Format: dd.MM.yyyy). Type 0 to abort and return to Main Menu!";

            Console.WriteLine(message);
            PrintDateInputMessage();

            string dateInput = Console.ReadLine();

            if (isForUpdate && string.IsNullOrWhiteSpace(dateInput))
            {
                return "0";
            }

            if (!isForUpdate && dateInput == "0")
            {
                Console.WriteLine();
                return "0";
            }

            bool isValidDate = DateTime.TryParseExact(
                dateInput,
                "dd.MM.yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out DateTime date);

            while (!isValidDate)
            {
                PrintInvalidDateInputError();
                PrintDateInputMessage();

                dateInput = Console.ReadLine();

                if (isForUpdate && string.IsNullOrWhiteSpace(dateInput))
                {
                    return "0";
                }

                if (!isForUpdate && dateInput == "0")
                {
                    Console.WriteLine();
                    return "0";
                }

                isValidDate = DateTime.TryParseExact(
                    dateInput,
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out date);
            }

            return date.ToString(TableDateColumnFormat);
        }
    }
}
