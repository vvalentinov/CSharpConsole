namespace WaterIntake
{
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
            Console.WriteLine($"{new string('-', 50)}{Environment.NewLine}");

            Console.Write("Your choice: ");
        }
    }
}
