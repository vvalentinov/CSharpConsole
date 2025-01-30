using TextAnalyzer;

ConsolePrinter.PrintWelcomeMessage();

string filePath = ConsoleReader.GetFilePath();

(bool isFilePathValid, string errMessage) = Validator.IsFilePathValid(filePath, ".txt");

while (isFilePathValid == false)
{
    ConsolePrinter.PrintError(errMessage);
    ConsolePrinter.PrintNewLine();
    filePath = ConsoleReader.GetFilePath();
    (isFilePathValid, errMessage) = Validator.IsFilePathValid(filePath, ".txt");
}

string text = File.ReadAllText(filePath);

int charactersCountWithSpaces = Analyzer.GetCharactersCountWithSpaces(text);
int charactersCountWithoutSpaces = Analyzer.GetCharactersCountWithoutSpaces(text);
int wordsCount = Analyzer.GetWordsCount(text);
string[] longestWords = Analyzer.GetLongestWords(text);
string[] smallestWords = Analyzer.GetSmallestWords(text);
var wordsOccurences = Analyzer.GetWordsOccurences(text);

ConsolePrinter.PrintDashedLine();

ConsolePrinter.PrintCharactersCount(charactersCountWithSpaces, charactersCountWithoutSpaces);
ConsolePrinter.PrintNumberOfWords(wordsCount);
ConsolePrinter.PrintLongestWords(longestWords);
ConsolePrinter.PrintSmallestWords(smallestWords);
ConsolePrinter.PrintWordsOccurrences(wordsOccurences);