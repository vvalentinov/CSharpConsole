namespace WaterIntake
{
    using Microsoft.Data.Sqlite;
    using System.Globalization;

    using static WaterIntake.DbConstants;
    using static WaterIntake.ConsolePrinter;
    using static WaterIntake.ConsoleReader;

    public static class WaterIntakeDataAccess
    {
        private const string DbConnectionString = $"Data Source=WaterIntake.db";

        public static async Task CreateWaterIntakeTableAsync()
        {
            await using var connection = new SqliteConnection(DbConnectionString);

            await connection.OpenAsync();

            var createTableCommand = new SqliteCommand(
                CreateDrinkingHabitTableQuery,
                connection);

            await createTableCommand.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        public static async Task InsertAsync()
        {
            string date = GetDateInput();

            if (date == "0")
            {
                return;
            }

            decimal litres = GetLitresInput();

            if (litres == 0)
            {
                return;
            }

            using var connection = new SqliteConnection(DbConnectionString);

            await connection.OpenAsync();

            string query = $"INSERT INTO {TableName}(date, litres) VALUES('{date}', {litres})";

            using var insertRecordCommand = new SqliteCommand(query, connection);

            await insertRecordCommand.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        public static async Task GetAllRecordsAsync()
        {
            using var connection = new SqliteConnection(DbConnectionString);

            await connection.OpenAsync();

            using var command = new SqliteCommand(GetAllRecordsQuery, connection);

            using var reader = await command.ExecuteReaderAsync();

            if (reader.HasRows)
            {
                Console.WriteLine();

                while (await reader.ReadAsync())
                {
                    var record = new WaterIntakeTableRecord
                    {
                        Id = reader.GetInt32(0),
                        Date = DateTime.ParseExact(
                            reader.GetString(1),
                            "yyyy-MM-dd",
                            CultureInfo.InvariantCulture),
                        Litres = reader.GetDecimal(2),
                    };

                    Console.WriteLine(record.ToString());
                }

                Console.WriteLine();
            }
            else
            {
                PrintNoRecordsFoundMessage();
            }
        }

        public static async Task DeleteRecordAsync()
        {
            Console.WriteLine("Type the id of the record you want to delete!");
            PrintRecordIdInput();

            bool isIdValid = int.TryParse(Console.ReadLine(), out int recordId);

            while (!isIdValid)
            {
                PrintInvalidRecordIdError();
                PrintRecordIdInput();
                isIdValid = int.TryParse(Console.ReadLine(), out recordId);
            }

            using var connection = new SqliteConnection(DbConnectionString);

            await connection.OpenAsync();

            using var deleteRecordWithIdCommand = new SqliteCommand(
                DeleteRecordQuery,
                connection);

            deleteRecordWithIdCommand.Parameters.AddWithValue("@RecordID", recordId);

            int rowsAffected = await deleteRecordWithIdCommand.ExecuteNonQueryAsync();

            if (rowsAffected > 0)
            {
                PrintDeleteRecordSuccess();
            }
            else
            {
                PrintNoRecordFoundError();
            }

            await connection.CloseAsync();
        }

        public static async Task UpdateRecordAsync()
        {
            Console.WriteLine("Type the id of the record you want to update!");

            bool isIdValid = int.TryParse(Console.ReadLine(), out int recordId);

            while (!isIdValid)
            {
                Console.WriteLine("The id of the record must be a valid number! Try, again!");
                isIdValid = int.TryParse(Console.ReadLine(), out recordId);
            }

            string date = GetDateInput(isForUpdate: true);
            decimal litres = GetLitresInput(isForUpdate: true);

            if (date == "0" && litres == 0)
            {
                return;
            }

            var queryBuilder = new List<string>();
            var parameters = new List<SqliteParameter>();

            if (date != "0")
            {
                queryBuilder.Add("Date=@Date");
                parameters.Add(new SqliteParameter("@Date", date));
            }

            if (litres != 0)
            {
                queryBuilder.Add("Litres=@Litres");
                parameters.Add(new SqliteParameter("@Litres", litres));
            }

            string query = $"UPDATE {TableName} SET {string.Join(", ", queryBuilder)} WHERE Id=@RecordID";
            parameters.Add(new SqliteParameter("@RecordID", recordId));

            using var connection = new SqliteConnection(DbConnectionString);

            await connection.OpenAsync();

            using var updateRecordCommand = new SqliteCommand(query, connection);
            updateRecordCommand.Parameters.AddRange(parameters);

            var rowsAffected = await updateRecordCommand.ExecuteNonQueryAsync();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Record updated successfully.");
            }
            else
            {
                Console.WriteLine("No record found with the given ID.");
            }

            await connection.CloseAsync();
        }
    }
}
