namespace PasswordGenerator
{
    public static class Validator
    {
        public static bool IsPassLengthInputValid(string passLengthInput)
            => byte.TryParse(passLengthInput, out byte passLength) && passLength >= 5 && passLength <= 100;

        public static bool IsUserYesOrNoInputValid(string userInput)
            => userInput == "yes" || userInput == "no";
    }
}
