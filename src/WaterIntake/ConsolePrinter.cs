namespace WaterIntake
{
    public static class ConsolePrinter
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("MAIN MENU");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Type 0 to close the application.");
            Console.WriteLine("Type 1 to view all records.");
            Console.WriteLine("Type 2 to insert a record.");
            Console.WriteLine("Type 3 to delete a record.");
            Console.WriteLine("Type 4 to update a record.");
            Console.WriteLine($"{new string('-', 50)}{Environment.NewLine}");
        }

        public static void PrintYourChoiceMessage()
            => Console.Write("Your choice: ");

        public static void PrintInvalidMenuOptionError()
        {
            var originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: You entered invalid menu option! Valid options: 0, 1, 2, 3 or 4! Try again!{Environment.NewLine}");

            Console.ForegroundColor = originalColor;
        }

        public static void PrintGoodbyeMessage()
            => Console.WriteLine("Thanks for hanging out with us! Until next time, stay awesome!");

        public static void PrintNoRecordsFoundMessage()
        {
            var originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Looks like no records were found!{Environment.NewLine}");

            Console.ForegroundColor = originalColor;
        }

        public static void PrintInsertRecordNoDateError()
        {
            var originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: You cannot insert a record without specifying a date!{Environment.NewLine}");

            Console.ForegroundColor = originalColor;
        }

        public static void PrintDateInputMessage()
            => Console.Write("Date: ");

        public static void PrintLitresInputMessage()
            => Console.Write("Litres: ");

        public static void PrintInvalidDateInputError()
        {
            var originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: Invalid date. (Format: dd.MM.yyyy)!{Environment.NewLine}");

            Console.ForegroundColor = originalColor;
        }

        public static void PrintInvalidLitresInputError()
        {
            var originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: Invalid number for litres! Must be a positive integer! Try again!{Environment.NewLine}");

            Console.ForegroundColor = originalColor;
        }

        public static void PrintRecordIdInput()
            => Console.Write("RecordId: ");

        public static void PrintInvalidRecordIdError()
        {
            var originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: The id of the record must be a valid number! Try, again!{Environment.NewLine}");

            Console.ForegroundColor = originalColor;
        }

        public static void PrintNoRecordFoundError()
        {
            var originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error: No record found with the given ID!{Environment.NewLine}");

            Console.ForegroundColor = originalColor;
        }

        public static void PrintDeleteRecordSuccess()
        {
            var originalColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Success: Record deleted successfully.{Environment.NewLine}");

            Console.ForegroundColor = originalColor;
        }
    }
}
