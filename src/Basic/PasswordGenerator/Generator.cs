namespace PasswordGenerator
{
    using System.Text;
    using System.Security.Cryptography;

    public static class Generator
    {
        public static string GeneratePassword(string characters, byte passLength)
        {
            var passwordBuilder = new StringBuilder();

            using (RandomNumberGenerator generator = RandomNumberGenerator.Create())
            {
                for (byte i = 0; i < passLength; i++)
                {
                    byte[] randomNumber = new byte[1];
                    generator.GetBytes(randomNumber);

                    int index = randomNumber[0] % characters.Length;
                    passwordBuilder.Append(characters[index]);
                }
            }

            return passwordBuilder.ToString();
        }

        public static void GenerateFileToDesktop(string content, string fileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, fileName);
            File.WriteAllText(filePath, content);
        }
    }
}
