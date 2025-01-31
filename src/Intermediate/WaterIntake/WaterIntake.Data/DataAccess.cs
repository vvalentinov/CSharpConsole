namespace WaterIntake.Data
{
    using Microsoft.Data.Sqlite;
    using System.Globalization;

    using static WaterIntake.Data.DbConstants;

    public static class DataAccess
    {
        private const string DbConnectionString = $"Data Source={DbName}.db";

        public static async Task CreateWaterIntakeTableAsync()
        {
            await using var connection = new SqliteConnection(DbConnectionString);

            await connection.OpenAsync();

            var createTableCommand = new SqliteCommand(CreateDrinkingHabitTableQuery, connection);

            await createTableCommand.ExecuteNonQueryAsync();

            await connection.CloseAsync();
        }

        public static async Task<int> InsertAsync(string date, float litres)
        {
            using var connection = new SqliteConnection(DbConnectionString);

            await connection.OpenAsync();

            string query = $"INSERT INTO {TableName}(date, litres) VALUES('{date}', {litres})";

            using var insertRecordCommand = new SqliteCommand(query, connection);

            int rowsAffected = await insertRecordCommand.ExecuteNonQueryAsync();

            await connection.CloseAsync();

            return rowsAffected;
        }

        public static async Task<List<TableRecord>> GetAllRecordsAsync()
        {
            var result = new List<TableRecord>();

            using var connection = new SqliteConnection(DbConnectionString);

            await connection.OpenAsync();

            using var command = new SqliteCommand(GetAllRecordsQuery, connection);

            using var reader = await command.ExecuteReaderAsync();

            while (await reader.ReadAsync())
            {
                var record = new TableRecord
                {
                    Id = reader.GetInt32(0),
                    Date = DateTime.ParseExact(
                        reader.GetString(1),
                        TableDateColumnFormat,
                        CultureInfo.InvariantCulture),
                    Litres = reader.GetDecimal(2),
                };

                result.Add(record);
            }

            await connection.CloseAsync();

            return result;
        }

        public static async Task<int> DeleteRecordAsync(int recordId)
        {
            using var connection = new SqliteConnection(DbConnectionString);

            await connection.OpenAsync();

            using var deleteRecordWithIdCommand = new SqliteCommand(DeleteRecordQuery, connection);

            deleteRecordWithIdCommand.Parameters.AddWithValue("@RecordID", recordId);

            int rowsAffected = await deleteRecordWithIdCommand.ExecuteNonQueryAsync();

            await connection.CloseAsync();

            return rowsAffected;
        }

        public static async Task<int> UpdateRecordAsync(
            int recordId,
            string date,
            float litres)
        {
            var queryBuilder = new List<string>();
            var parameters = new List<SqliteParameter>();

            if (string.IsNullOrWhiteSpace(date) == true && litres == 0)
            {
                return 0;
            }

            if (string.IsNullOrWhiteSpace(date) == false)
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

            await connection.CloseAsync();

            return rowsAffected;
        }
    }
}
