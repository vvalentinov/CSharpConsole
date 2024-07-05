# Password Generator

Basic password generator implemented as a C# console application.

## Features

- Validation of the user input.
- Simple user interface via the console.
- Generates random passwords based on user-specified length and character types.
- Allows customization of password complexity (e.g., including uppercase letters, digits, symbols).

## Password Generation

In this project, the password generation functionality is implemented using the RandomNumberGenerator class from the System.Security.Cryptography namespace in C#. The RandomNumberGenerator class provides a secure and efficient way to generate random numbers, which are crucial for creating strong and unpredictable passwords. The end result is printed to the console and is also saved in a .txt file on the user Desktop.