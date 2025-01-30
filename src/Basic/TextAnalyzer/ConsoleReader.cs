namespace TextAnalyzer
{
    public static class ConsoleReader
    {
        public static string GetFilePath()
        {
            Console.WriteLine("Enter the path to the text file below.");
            Console.Write("Path: ");

            string filePath = Console.ReadLine() ?? string.Empty;

            return filePath;
        }
    }
}
