namespace PasswordGenerator
{
    public static class CharacterPool
    {
        public static string Numbers { get { return "0123456789"; } }

        public static string UpperCase { get { return "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; } }

        public static string LowerCase { get { return UpperCase.ToLower(); } }

        public static string Special { get { return "!#$%^&*()-_+=:;\"?/<>.{}[]@`~"; } }
    }
}
