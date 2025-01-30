namespace TextAnalyzer
{
    using System;
    using static System.ConsoleColor;

    public static class ConsolePrinter
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome To The TextAnalyzer!");
            Console.WriteLine("==================================");
            Console.WriteLine("        TEXT ANALYZER       ");
            Console.WriteLine("==================================");
            Console.WriteLine("This program reads the contents of a .txt file and analyzes the text.");
            PrintNewLine();
        }

        public static void PrintDashedLine(int length = 100) => Console.WriteLine(new string('-', length));

        public static void PrintNewLine() => Console.Write(Environment.NewLine);

        public static void PrintCharactersCount(int withSpaces, int withoutSpaces)
        {
            Console.WriteLine($"Characters count: {withSpaces}");
            Console.WriteLine($"Characters count without spaces: {withoutSpaces}");
        }

        public static void PrintTextInput() => Console.Write("Text: ");

        public static void PrintLongestWords(string[] longestWords)
        {
            if (longestWords.Length == 1)
            {
                Console.WriteLine($"Longest word: {longestWords[0]}");
            }
            else
            {
                Console.WriteLine($"Longest words: {string.Join(", ", longestWords)}");
            }
        }

        public static void PrintSmallestWords(string[] smallestWords)
        {
            if (smallestWords.Length == 1)
            {
                Console.WriteLine($"Smallest word: {smallestWords[0]}");
            }
            else
            {
                Console.WriteLine($"Smallest words: {string.Join(", ", smallestWords)}");
            }
        }

        public static void PrintNumberOfWords(int wordsCount)
        {
            Console.WriteLine($"Number of words found: {wordsCount}");
        }

        public static void PrintWordsOccurrences(Dictionary<string, int> wordsOccurences)
        {
            Console.WriteLine("Words with their number of occurrences:");

            foreach (var kvp in wordsOccurences)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }

        public static void PrintError(string message)
        {
            Console.ForegroundColor = DarkRed;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
