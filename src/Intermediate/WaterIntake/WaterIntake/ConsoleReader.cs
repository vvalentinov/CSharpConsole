namespace WaterIntake
{
    using static WaterIntake.Messages;

    public static class ConsoleReader
    {
        public static string GetUserInput() => Console.ReadLine() ?? string.Empty;

        public static class Utils
        {
            public static string GetValidMenuChoiceInput()
            {
                string userChoice = GetUserInput();

                while (Validator.IsUserMenuChoiceValid(userChoice) == false)
                {
                    ConsolePrinter.PrintMessage(InvalidMenuOptionMessage, onSameLine: false, OutputMessageType.Error);
                    ConsolePrinter.PrintNewLine();
                    ConsolePrinter.PrintMainMenu();
                    ConsolePrinter.PrintMessage(UserMenuChoiceMessage, onSameLine: true);
                    userChoice = GetUserInput();
                }

                return userChoice;
            }

            public static string GetValidDateInput(bool isForUpdate = false)
            {
                string date = GetUserInput();

                if (isForUpdate && date == string.Empty)
                {
                    return string.Empty;
                }

                while (Validator.IsDateInputInValidFormat(date) == false)
                {
                    ConsolePrinter.PrintMessage(IncorrectDateMessage, onSameLine: false, OutputMessageType.Error);
                    ConsolePrinter.PrintNewLine();
                    ConsolePrinter.PrintMessage("Date: ", onSameLine: true);
                    date = GetUserInput();
                }

                return date;
            }

            public static string GetValidLitresInput(bool isForUpdate = false)
            {
                string litresInput = GetUserInput();

                if (isForUpdate && litresInput == string.Empty)
                {
                    return string.Empty;
                }

                while (Validator.IsLitresInputInValid(litresInput) == false)
                {
                    ConsolePrinter.PrintMessage(InvalidLitresInputMessage, onSameLine: false, OutputMessageType.Error);
                    ConsolePrinter.PrintNewLine();
                    ConsolePrinter.PrintMessage("Litres: ", onSameLine: true);
                    litresInput = GetUserInput();
                }

                return litresInput;
            }

            public static string GetValidRecordIdInput()
            {
                string recordIdInput = GetUserInput();

                while (Validator.IsRecordIdValidInteger(recordIdInput) == false)
                {
                    ConsolePrinter.PrintMessage(InvalidRecordIdInputMessage, onSameLine: false, OutputMessageType.Error);
                    ConsolePrinter.PrintNewLine();
                    ConsolePrinter.PrintMessage(InsertRecordId, onSameLine: true);
                    recordIdInput = GetUserInput();
                }

                return recordIdInput;
            }
        }
    }
}