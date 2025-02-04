Console.WriteLine("Welcome to the Vowel Counter!");
Console.WriteLine("English vowels: a, e, i, o, u.");
Console.WriteLine("Place your text below.");
Console.Write("Text: ");

string text = Console.ReadLine()?.ToLower() ?? string.Empty;

while (string.IsNullOrWhiteSpace(text))
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("The input was not valid! Try, again.");
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine("Place your text below.");
    Console.Write("Text: ");
    text = Console.ReadLine()?.ToLower() ?? string.Empty;
}

// Option 1
//Dictionary<char, int> dictionary = new()
//{
//    {'a', text.Count(x => x == 'a') },
//    {'e', text.Count(x => x == 'e') },
//    {'i', text.Count(x => x == 'i') },
//    {'o', text.Count(x => x == 'o') },
//    {'u', text.Count(x => x == 'u') },
//};

// Option 2
Dictionary<char, int> dictionary = new()
{
    {'a', 0},
    {'e', 0},
    {'i', 0},
    {'o', 0},
    {'u', 0},
};

foreach (char character in text)
{
    if (dictionary.TryGetValue(character, out int value))
    {
        dictionary[character] = ++value;
    }
}

int totalVowes = dictionary.Sum(x => x.Value);

Console.WriteLine(new string('-', 100));
Console.WriteLine($"Total number of vowels is: {totalVowes}.");

foreach (var item in dictionary)
{
    Console.WriteLine($"Vowel '{item.Key}' occurres {item.Value} times.");
}
