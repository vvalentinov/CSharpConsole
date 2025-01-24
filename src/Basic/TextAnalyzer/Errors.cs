namespace TextAnalyzer
{
    public static class Errors
    {
        private const string Prefix = "Error: ";

        public const string NoWordsError = $"{Prefix}Looks like no words were found in the text!";

        public const string EmptyTextError = $"{Prefix}Looks like you didn't paste any text! Try, again!";
    }
}
