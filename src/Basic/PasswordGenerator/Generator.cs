namespace PasswordGenerator
{
    using System.Text;
    using System.Security.Cryptography;

    public static class Generator
    {
        public static string GeneratePassword(string characters, byte passLength)
        {
            var passwordBuilder = new StringBuilder();

            using (var generator = RandomNumberGenerator.Create())
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

        public static string GenerateFile(string password)
        {
            var fileName = "MyStrongPassword.txt";
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            File.WriteAllText(Path.Combine(desktopPath, fileName), password);
            return fileName;
        }
    }
}
