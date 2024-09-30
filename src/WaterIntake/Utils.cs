namespace WaterIntake
{
    public static class Utils
    {
        public static string GetDbConnectionString()
        {
            string dbPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                @"..\..\..\HabitTracker.db");

            return $"Data Source={dbPath}";
        }
    }
}
