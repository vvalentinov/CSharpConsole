namespace PasswordGenerator
{
    using System.Text;

    public static class Generator
    {
        public static string GenerateCharacters(
            string inputOptions,
            IDictionary<char, string> charactersList)
        {
            string[] options = inputOptions.Split(' ');

            var sb = new StringBuilder();

            foreach (var option in options)
            {
                sb.Append(charactersList[Char.Parse(option)]);
            }

            return sb.ToString();
        }

        public static string GeneratePassword(string characters, int passLength)
        {
            var random = new Random();
            var passwordBuilder = new StringBuilder();

            for (int i = 0; i < passLength; i++)
            {
                var randomIndex = random.Next(0, characters.Length - 1);
                passwordBuilder.Append(characters[randomIndex]);
            }

            return passwordBuilder.ToString();
        }

        public static string GenerateFile(string password)
        {
            var fileName = "MyStrongPassword.txt";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllText(Path.Combine(desktopPath, fileName), password);
            return fileName;
        }
    }
}
