namespace TextAnalyzer
{
    using System;
    using static System.ConsoleColor;

    public static class Printer
    {
        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to TextAnalyzer!");
            Console.WriteLine("Paste your text below!");
        }

        public static void PrintLine() => Console.WriteLine(new string('-', 100));

        public static void PrintCharactersCount(int withSpaces, int withoutSpaces)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = Green;
            Console.WriteLine($"Characters count (with spaces): {withSpaces}");
            Console.WriteLine($"Characters count (without spaces): {withoutSpaces}");
            Console.ForegroundColor = currentColor;
        }

        public static void PrintTextInput() => Console.Write("Text: ");

        public static void PrintLongestWords(IEnumerable<string> longestWords)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = Cyan;
            if (longestWords.Count() == 1)
            {
                Console.WriteLine($"Longest word: {longestWords.First()}");
            }
            else
            {
                Console.WriteLine($"Longest words: {string.Join(", ", longestWords)}");
            }
            Console.ForegroundColor = currentColor;
        }

        public static void PrintSmallestWords(IEnumerable<string> smallestWords)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = Cyan;
            if (smallestWords.Count() == 1)
            {
                Console.WriteLine($"Smallest word: {smallestWords.First()}");
            }
            else
            {
                Console.WriteLine($"Smallest words: {string.Join(", ", smallestWords)}");
            }
            Console.ForegroundColor = currentColor;
        }

        public static void PrintNumberOfWords(int wordsCount)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = Blue;
            Console.WriteLine($"Number of words found: {wordsCount}");
            Console.ForegroundColor = currentColor;
        }

        public static void PrintWordsOccurrences(IOrderedEnumerable<KeyValuePair<string, int>> wordFrequencies)
        {
            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = Yellow;
            Console.WriteLine("Words with their number of occurrences:");

            foreach (var kvp in wordFrequencies)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }

            Console.ForegroundColor = currentColor;
        }

        public static void DisplayError(string error)
        {
            var currentColor = Console.ForegroundColor;
            Console.ForegroundColor = Red;
            Console.WriteLine(error);
            Console.ForegroundColor = currentColor;
        }
    }
}
