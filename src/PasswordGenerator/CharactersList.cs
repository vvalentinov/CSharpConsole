namespace PasswordGenerator
{
    public static class CharactersList
    {
        private static string _numbers = "0123456789";
        private static string _uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static string _specialCharacters = "!#$%^&*()-_+=:;\"?/<>.{}[]@`~";
        private static string _all = string.Concat(
            _uppercase,
            _uppercase.ToLower(),
            _numbers,
            _specialCharacters);

        public static IDictionary<char, string> Characters
        {
            get
            {
                return new Dictionary<char, string>
                {
                    ['U'] = _uppercase,
                    ['L'] = _uppercase.ToLower(),
                    ['N'] = _numbers,
                    ['S'] = _specialCharacters,
                    ['A'] = _all
                };
            }
        }
    }
}
