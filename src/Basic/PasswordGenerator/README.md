# ⚙️ Password Generator

The Password Generator project allows users to generate secure, random passwords by selecting specific character sets, including numbers, uppercase letters, lowercase letters, and special characters. The program offers an interactive interface where the user is prompted to choose the desired character sets for their password. This allows for highly customizable password creation, ensuring that each password is as complex and secure as needed.

Once the user has made their selections, the program generates a strong password by randomly selecting characters from the chosen sets. The randomization process is powered by the ```RandomNumberGenerator``` class from the ```System.Security.Cryptography``` namespace in C#. This class is used to generate cryptographically secure random numbers, ensuring that the generated password is truly random and suitable for security-sensitive applications.

In addition to generating the password, the program offers the added convenience of saving the generated password to a text file on the user's **desktop**, making it easy for the user to store and access their newly created password later. The file is automatically named and placed on the desktop for immediate access.

## 🛠️ Features

- **Customizable Character Pool**  
    *The user is prompted to choose from a variety of character sets, such as numbers, uppercase, lowercase, and special characters, allowing for a personalized and secure password.*
- **Password Length Specification**  
    *The user can define the length of the password, giving full control over the generated output.*
- **Cryptographically Secure Randomization**  
    *The RandomNumberGenerator class from the System.Security.Cryptography namespace is used to generate a cryptographically secure random number, ensuring that the password is strong and unpredictable.*
- **Password File Creation**  
    *Once generated, the password is saved in a text file on the user's desktop, making it easy to retrieve or store for future use.*
- **Error Handling & User Guidance**  
    *The program features error handling to ensure that users are guided through the process and can easily correct any input mistakes, such as not selecting any character sets.*

This project demonstrates the use of secure random number generation, string manipulation, file handling, and user input validation. It’s an excellent example of how to build a simple yet effective tool for creating strong passwords in C#.