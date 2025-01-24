namespace TextAnalyzer
{
    using System.Linq;
    using static TextAnalyzer.Errors;
    using static TextAnalyzer.Printer;
    using System.Text.RegularExpressions;

    public static class Analyzer
    {
        public static void AnalyzeText(string text)
        {
            var noSpacesRegex = new Regex(@"\S");
            var wordsRegex = new Regex(@"\b(?:[a-zA-Z]{2,}|[AaI])\b");

            var wordsMatches = wordsRegex.Matches(text);
            var noSpacesMatches = noSpacesRegex.Matches(text);

            PrintLine();

            PrintCharactersCount(text.Length, noSpacesMatches.Count);

            int wordsCount = wordsMatches.Count;
            if (wordsCount > 0)
            {
                PrintNumberOfWords(wordsCount);

                var longestWords = GetLongestWords(wordsMatches);
                var smallestWords = GetSmallestWords(wordsMatches);
                var wordsOccurrences = GetWordsOccurrences(wordsMatches);

                PrintSmallestWords(smallestWords);
                PrintLongestWords(longestWords);
                PrintWordsOccurrences(wordsOccurrences);
            }
            else
            {
                DisplayError(NoWordsError);
            }
        }

        private static IEnumerable<string> GetLongestWords(MatchCollection wordsMatches)
        {
            int maxLength = wordsMatches.Max(m => m.Value.Length);

            return wordsMatches
                .Where(m => m.Value.Length == maxLength)
                .OrderBy(x => x.Value)
                .Select(m => m.Value)
                .Distinct();
        }

        private static IEnumerable<string> GetSmallestWords(MatchCollection wordsMatches)
        {
            int minLength = wordsMatches.Min(m => m.Value.Length);

            return wordsMatches
                .Where(m => m.Value.Length == minLength)
                .OrderBy(x => x.Value)
                .Select(m => m.Value)
                .Distinct();
        }

        private static IOrderedEnumerable<KeyValuePair<string, int>> GetWordsOccurrences(MatchCollection wordsMatches)
            => wordsMatches
                .GroupBy(m => m.Value.ToLower())
                .ToDictionary(g => g.Key, g => g.Count())
                .OrderByDescending(x => x.Value);
    }
}
