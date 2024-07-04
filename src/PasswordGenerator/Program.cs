using static PasswordGenerator.Validator;
using static PasswordGenerator.Generator;
using static PasswordGenerator.ConsolePrinter;
using static PasswordGenerator.CharacterPool;

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

var inputOptions = Console.ReadLine() ?? string.Empty;

(bool isInputOptionsValid, string validateOptionsMsg) = ValidateInputOptions(inputOptions);

while (!isInputOptionsValid)
{
    Console.WriteLine(validateOptionsMsg);
    PrintChooseOptionsMessage();
    inputOptions = Console.ReadLine() ?? string.Empty;
    (isInputOptionsValid, validateOptionsMsg) = ValidateInputOptions(inputOptions);
}

string characters = GenerateCharacters(inputOptions, Characters);

string password = GeneratePassword(characters, passLength);

Console.WriteLine(new string('=', 100));
Console.WriteLine($"Your password: {password}");

var fileName = GenerateFile(password);

Console.WriteLine($"A file with name: {fileName} was created on Desktop!");