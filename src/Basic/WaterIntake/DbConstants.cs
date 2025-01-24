namespace WaterIntake
{
    public static class DbConstants
    {
        public const string DbName = "WaterIntake";

        public const string TableName = "DrinkingHabit";

        public const string TableDateColumnFormat = "yyyy-MM-dd";

        public const string CreateDrinkingHabitTableQuery = @$"
            CREATE TABLE IF NOT EXISTS {TableName} (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Date TEXT NOT NULL,
                Litres REAL NOT NULL
            )";

        public const string GetAllRecordsQuery = $"SELECT * FROM {TableName}";

        public const string DeleteRecordQuery = $"DELETE FROM {TableName} WHERE Id = @RecordID";
    }
}
