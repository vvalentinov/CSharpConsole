namespace WaterIntake
{
    using WaterIntake.Data;

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
            Console.WriteLine($"{new string('-', 50)}");
        }

        public static void PrintNewLine() => Console.Write(Environment.NewLine);

        public static void PrintMessage(
            string message,
            bool onSameLine = false,
            OutputMessageType type = OutputMessageType.None)
        {
            switch (type)
            {
                case OutputMessageType.Error:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case OutputMessageType.Success:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case OutputMessageType.Warning:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
            }

            if (onSameLine == true)
            {
                Console.Write(message);
            }
            else
            {
                Console.WriteLine(message);
            }
            
            Console.ResetColor();
        }

        public static void PrintTableRecords(List<TableRecord> records)
        {
            if (records.Count == 0)
            {
                PrintMessage("Look's like no records were found!", onSameLine: false, OutputMessageType.Warning);
            }
            else
            {
                foreach (var record in records)
                {
                    PrintMessage(record.ToString());
                }
            }

            PrintNewLine();
        }

        public static void PrintDbOperationSuccessOrNot(int rowsAffected)
        {
            if (rowsAffected > 0)
            {
                PrintMessage("Successfull operation!", onSameLine: false, OutputMessageType.Success);
            }
            else
            {
                PrintMessage("Unsuccessfull operation!", onSameLine: false, OutputMessageType.Error);
            }
        }
    }
}
