namespace PasswordGenerator
{
    public static class CharacterPool
    {
        private readonly static string _numbers = "0123456789";
        private readonly static string _uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private readonly static string _special = "!#$%^&*()-_+=:;\"?/<>.{}[]@`~";
        private readonly static string _all = string.Concat(
            _uppercase,
            _uppercase.ToLower(),
            _numbers,
            _special);

        public static IDictionary<char, string> Characters
        {
            get
            {
                return new Dictionary<char, string>
                {
                    ['U'] = _uppercase,
                    ['L'] = _uppercase.ToLower(),
                    ['N'] = _numbers,
                    ['S'] = _special,
                    ['A'] = _all
                };
            }
        }
    }
}
