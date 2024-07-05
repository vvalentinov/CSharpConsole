using static PasswordGenerator.Validator;
using static PasswordGenerator.Generator;
using static PasswordGenerator.ConsolePrinter;
using static PasswordGenerator.CharacterPool;

Console.WriteLine("Welcome to your password generator!");
PrintChooseLengthMessage();

string length = Console.ReadLine() ?? string.Empty;

(bool isLengthValid, string validateLengthMsg) = ValidateLength(length);

while (!isLengthValid)
{
    Console.WriteLine(validateLengthMsg);
    Console.Write("Length: ");
    length = Console.ReadLine() ?? string.Empty;
    (isLengthValid, validateLengthMsg) = ValidateLength(length);
}

byte passLength = byte.Parse(length);

PrintCharacterOptions(Characters);

PrintChooseOptionsMessage();

string inputOptions = Console.ReadLine() ?? string.Empty;

string password;

if (string.IsNullOrWhiteSpace(inputOptions))
{
    password = GeneratePassword(Characters['A'], passLength);
}
else
{
    (bool isInputOptionsValid, string validateOptionsMsg) = ValidateInputOptions(inputOptions);

    while (!isInputOptionsValid)
    {
        Console.WriteLine(validateOptionsMsg);
        PrintChooseOptionsMessage();
        inputOptions = Console.ReadLine() ?? string.Empty;
        (isInputOptionsValid, validateOptionsMsg) = ValidateInputOptions(inputOptions);
    }

    string characters = GenerateCharacters(inputOptions, Characters);

    password = GeneratePassword(characters, passLength);
}

Console.WriteLine(new string('-', 100));
Console.WriteLine($"Your password: {password}");

var fileName = GenerateFile(password);

Console.WriteLine($"A file with name: {fileName} was created on Desktop!");