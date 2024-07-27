using static TextAnalyzer.Errors;
using static TextAnalyzer.Printer;
using static TextAnalyzer.Analyzer;

PrintWelcomeMessage();

PrintTextInput();

string? text = Console.ReadLine();

while (string.IsNullOrWhiteSpace(text))
{
    DisplayError(EmptyTextError);
    PrintTextInput();
    text = Console.ReadLine();
}

AnalyzeText(text);