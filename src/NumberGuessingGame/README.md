# Number Guessing Game

The Number Guessing Game is application where the user guesses a randomly generated number within a specified range. It provides the option to set custom lower and upper bounds or use default bounds. The program guides the user through input validation and provides feedback based on the correctness of the guessed number.

## Features

- Provides clear error messages for incorrect inputs.
- Validates user inputs for bounds and guessed number.
- Allows user to set custom lower and upper bounds for number guessing.
- Uses System.Security.Cryptography.RandomNumberGenerator for secure random number generation.

## Validation Methods

The following validation methods ensure that user inputs are correct and within specified bounds:

### ValidateLowerBound

Checks if the provided lower bound input is valid.

### ValidateUpperBound

Checks if the provided upper bound input is valid and greater than the lower bound.

### ValidateGuessedNumber

Validates the user's guessed number against the specified range and the randomly generated number.