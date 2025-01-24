using static PasswordGenerator.Generator;
using static PasswordGenerator.ConsoleReader;
using static PasswordGenerator.CharacterPool;
using static PasswordGenerator.ConsolePrinter;

Console.WriteLine("Welcome To Your Password Generator!");

byte passLength = GetPasswordLength();

string characterPool = string.Empty;

while (characterPool == string.Empty)
{
    PrintChooseCharactersMessage("numbers", Numbers);
    characterPool += GetUserYesOrNoChoice() == "yes" ? Numbers : string.Empty;

    PrintChooseCharactersMessage("uppercase", UpperCase);
    characterPool += GetUserYesOrNoChoice() == "yes" ? UpperCase : string.Empty;

    PrintChooseCharactersMessage("lowercase", LowerCase);
    characterPool += GetUserYesOrNoChoice() == "yes" ? LowerCase : string.Empty;

    PrintChooseCharactersMessage("special", Special);
    characterPool += GetUserYesOrNoChoice() == "yes" ? Special : string.Empty;

    if (characterPool == string.Empty)
    {
        PrintErrorMessage("Oops! Look's like you didn't pick an option. Let's do this again.");
    }
}

string password = GeneratePassword(characterPool, passLength);
Console.WriteLine(new string('-', 100));
Console.WriteLine($"Your password: {password}");

var fileName = GenerateFile(password);
Console.WriteLine($"A file with name: {fileName} was created on Desktop!");