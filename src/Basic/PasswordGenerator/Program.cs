using PasswordGenerator;

Console.WriteLine("Welcome To Your Password Generator!");

string passLengthInput = ConsoleReader.GetPasswordLength();
bool isPassLengthInputValid = Validator.IsPassLengthInputValid(passLengthInput);
while (isPassLengthInputValid == false)
{
    ConsolePrinter.PrintErrorMessage("Looks like the input you entered was invalid! Try, again!");
    ConsolePrinter.PrintNewLine();
    passLengthInput = ConsoleReader.GetPasswordLength();
    isPassLengthInputValid = Validator.IsPassLengthInputValid(passLengthInput);
}

byte passLength = byte.Parse(passLengthInput);

string characterPool = string.Empty;

while (characterPool == string.Empty)
{
    ConsolePrinter.PrintChooseCharactersMessage("numbers", CharacterPool.Numbers);
    characterPool += GetValidYesOrNoChoice() == "yes" ? CharacterPool.Numbers : string.Empty;
    ConsolePrinter.PrintNewLine();

    ConsolePrinter.PrintChooseCharactersMessage("uppercase", CharacterPool.UpperCase);
    characterPool += GetValidYesOrNoChoice() == "yes" ? CharacterPool.UpperCase : string.Empty;
    ConsolePrinter.PrintNewLine();

    ConsolePrinter.PrintChooseCharactersMessage("lowercase", CharacterPool.LowerCase);
    characterPool += GetValidYesOrNoChoice() == "yes" ? CharacterPool.LowerCase : string.Empty;
    ConsolePrinter.PrintNewLine();

    ConsolePrinter.PrintChooseCharactersMessage("special", CharacterPool.Special);
    characterPool += GetValidYesOrNoChoice() == "yes" ? CharacterPool.Special : string.Empty;
    ConsolePrinter.PrintNewLine();

    if (characterPool.Length > 0)
    {
        break;
    }

    ConsolePrinter.PrintErrorMessage("Oops! Look's like you didn't pick an option. Let's do this again.");
    ConsolePrinter.PrintNewLine();
}

string password = Generator.GeneratePassword(characterPool, passLength);
Console.WriteLine(new string('-', 100));
Console.WriteLine($"Your password: {password}");

string fileName = "MyStrongPassword.txt";
Generator.GenerateFileToDesktop(password, fileName);
Console.WriteLine($"A file with name: {fileName} was created on Desktop!");

static string GetValidYesOrNoChoice()
{
    string choice = ConsoleReader.GetUserYesOrNoChoice();

    while (Validator.IsUserYesOrNoInputValid(choice) == false)
    {
        ConsolePrinter.PrintErrorMessage("Oops! Look's like you made a mistake with your spelling! Try, again!");
        ConsolePrinter.PrintNewLine();
        choice = ConsoleReader.GetUserYesOrNoChoice();
    }

    return choice;
}