namespace NumberGuessingGame
{
    public static class Validator
    {
        public static bool IsUserBoundsChoiceValid(string userBoundsAnswer)
            => userBoundsAnswer == "yes" || userBoundsAnswer == "no";
        
        public static bool IsLowerBoundValid(string lowerBoundInput, int maxLowerBoundValue)
            => int.TryParse(lowerBoundInput, out int lowerBound) && lowerBound <= maxLowerBoundValue;

        public static bool IsUpperBoundValid(string upperBoundInput, int lowerBound)
            => int.TryParse(upperBoundInput, out int upperBound) && (upperBound >= lowerBound + 100);

        public static bool IsUserGuessValid(string userGuessInput, int lowerBound, int upperBound)
            => int.TryParse(userGuessInput, out int userGuess) && userGuess >= lowerBound && userGuess <= upperBound;
    }
}
