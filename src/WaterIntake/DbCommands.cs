namespace WaterIntake
{
    public static class DbCommands
    {
        public const string CreateDrinkingHabitTableCmd = @"
            CREATE TABLE IF NOT EXISTS DrinkingHabit (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Date TEXT NOT NULL,
                Litres REAL NOT NULL
            )";
    }
}
