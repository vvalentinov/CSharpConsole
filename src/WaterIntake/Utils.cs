namespace WaterIntake
{
    using Microsoft.Data.Sqlite;

    using static WaterIntake.DbCommands;

    public static class Utils
    {
        public static string GetDbConnectionString()
        {
            string dbPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                @"..\..\..\HabitTracker.db");

            return $"Data Source={dbPath}";
        }

        public static async Task CreateWaterIntakeTableAsync()
        {
            var dbConnection = GetDbConnectionString();

            await using var connection = new SqliteConnection(dbConnection);

            await connection.OpenAsync();

            var createTableCommand = new SqliteCommand(
                CreateDrinkingHabitTableCmd,
                connection);

            await createTableCommand.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }
    }
}
