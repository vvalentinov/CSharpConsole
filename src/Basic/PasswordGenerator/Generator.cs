namespace PasswordGenerator
{
    using System.Security.Cryptography;
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
            var passwordBuilder = new StringBuilder();

            using (var generator = RandomNumberGenerator.Create())
            {
                for (int i = 0; i < passLength; i++)
                {
                    byte[] randomNumber = new byte[1];
                    generator.GetBytes(randomNumber);

                    int index = randomNumber[0] % characters.Length;
                    passwordBuilder.Append(characters[index]);
                }
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
