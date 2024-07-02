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
    }
}
