using static PasswordGenerator.Validator;
using static PasswordGenerator.Generator;
using static PasswordGenerator.ConsolePrinter;
using static PasswordGenerator.CharactersList;

PrintChooseLengthMessage();

int passLength = ValidateLength(Console.ReadLine() ?? string.Empty);

PrintCharacterOptions(Characters);

PrintChooseOptionsMessage();

string inputCharactersOptions = ValidateInputOptions(Console.ReadLine() ?? string.Empty);

string characters = GenerateCharacters(inputCharactersOptions, Characters);

string password = GeneratePassword(characters, passLength);

Console.WriteLine(new string('=', 100));
Console.WriteLine($"Your password: {password}");

var fileName = GenerateFile(password);

Console.WriteLine($"A file with name: {fileName} was created on Desktop!");