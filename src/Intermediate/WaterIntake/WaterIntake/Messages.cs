namespace WaterIntake
{
    using WaterIntake.Data;

    public static class Messages
    {
        public const string InsertDateMessage = $"Insert date: (Format: {DbConstants.TableDateColumnFormat}).";

        public const string InsertLitresMessage = "Insert litres. Enter a positive number with up to 3 decimal places (e.g., 2.540).";

        public const string InsertRecordId = "Insert record id: ";

        public const string InvalidMenuOptionMessage = "Error: You entered invalid menu option! Valid options: 0, 1, 2, 3 or 4! Try again!";

        public const string UserMenuChoiceMessage = "Your Choice: ";

        public const string GoodbyeMessage = "Thanks for hanging out with us! Until next time, stay awesome!";

        public const string IncorrectDateMessage = $"Error: The date was not correct. Try, again! Format: {DbConstants.TableDateColumnFormat}";

        public const string InvalidLitresInputMessage = "Error: The litres input was invalid. Try, again.";

        public const string InvalidRecordIdInputMessage = "Error: The recordId input was invalid. Try, again!";
    }
}
