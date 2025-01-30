namespace TextAnalyzer
{
    using System.Linq;

    public static class Analyzer
    {
        public static int GetCharactersCountWithSpaces(string text) => text.Length;

        public static int GetCharactersCountWithoutSpaces(string text)
        {
            string textWithoutSpaces = new(text.Where(c => !char.IsWhiteSpace(c)).Select(c => c).ToArray());
            return textWithoutSpaces.Length;
        }

        public static int GetWordsCount(string text)
        {
            string[] words = GetWords(text);
            return words.Length;
        }

        public static string[] GetLongestWords(string text)
        {
            string[] words = GetWords(text);
            int maxLength = words.Max(word => word.Length);
            return words
                .Where(word => word.Length == maxLength)
                .Select(word => word.ToLower())
                .Distinct()
                .ToArray();
        }

        public static string[] GetSmallestWords(string text)
        {
            string[] words = GetWords(text);
            int minLength = words.Min(word => word.Length);
            return words
                .Where(word => word.Length == minLength)
                .Select(word => word.ToLower())
                .Distinct()
                .ToArray();
        }

        public static string[] GetWords(string text) => text.Split([' ', '\t', '\n', '\r', '.', ',', ';', '!', '?'], StringSplitOptions.RemoveEmptyEntries);

        public static Dictionary<string, int> GetWordsOccurences(string text)
        {
            string[] words = GetWords(text).Select(word => word.ToLower()).ToArray();

            var dictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dictionary.ContainsKey(word))
                {
                    dictionary[word]++;
                }
                else
                {
                    dictionary.Add(word, 1);
                }
            }

            return dictionary
                .OrderByDescending(x => x.Value)
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }
    }
}
