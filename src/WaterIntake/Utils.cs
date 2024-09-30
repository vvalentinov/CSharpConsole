namespace WaterIntake
{
    using Microsoft.Data.Sqlite;
    using System.Globalization;
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

        public static async Task InsertAsync()
        {
            string date = GetDateInput();

            if (string.IsNullOrEmpty(date))
            {
                return;
            }

            var connectionString = GetDbConnectionString();

            decimal litres = GetLitresInput();

            using var connection = new SqliteConnection(connectionString);

            await connection.OpenAsync();

            string query = $"INSERT INTO DrinkingHabit(date, litres) VALUES('{date}', {litres})";

            var tableCmd = new SqliteCommand(query, connection);

            await tableCmd.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        public static async Task GetAllRecordsAsync()
        {
            string connectionString = GetDbConnectionString();

            string query = "SELECT * FROM DrinkingHabit";

            using var connection = new SqliteConnection(connectionString);

            await connection.OpenAsync();

            using var command = new SqliteCommand(query, connection);

            using var reader = await command.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                while (await reader.ReadAsync())
                {
                    int id = reader.GetInt32(0);

                    DateTime date = DateTime.ParseExact(
                        reader.GetString(1),
                        "dd-MM-yy",
                        new CultureInfo("en-US"));

                    decimal litres = reader.GetDecimal(2);

                    Console.WriteLine($"Id: {id}, Date: {date.ToString("dd-MMM-yyyy")}, Litres: {litres}");
                }
            }
            else
            {
                Console.WriteLine("No records found!");
            }
        }

        private static decimal GetLitresInput()
        {
            Console.WriteLine("Insert litres quantity.");

            string numberInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(numberInput))
            {
                return 0;
            }

            bool isValidNumber = decimal.TryParse(numberInput, out decimal litres);
            bool isValid = isValidNumber && litres > 0;

            while (!isValid)
            {
                Console.WriteLine("Invalid number for litres! Must be a positive integer! Try again!");
                isValidNumber = decimal.TryParse(numberInput, out litres);
                isValid = isValidNumber && litres > 0;
            }

            return litres;
        }

        private static string GetDateInput()
        {
            Console.WriteLine("Please insert the date: (Format: dd-mm-yy).");

            string dateInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(dateInput))
            {
                return string.Empty;
            }

            while (!DateTime.TryParseExact(
                dateInput,
                "dd-MM-yy",
                new CultureInfo("en-US"),
                DateTimeStyles.None,
                out _))
            {
                Console.WriteLine("Invalid date. (Format: dd-mm-yy). Type 0 to return to main manu or try again:");
                dateInput = Console.ReadLine();
            }

            return dateInput;
        }
    }
}
