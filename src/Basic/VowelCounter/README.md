# Vowel Counter 🎤

Vowel Counter is a simple C# console application that counts the occurrences of vowels (a, e, i, o, u) in a given input text. It provides a user-friendly interface and ensures valid input before processing.

### Features
✅ Reads user input and converts it to lowercase for uniform processing.  
✅ Handles invalid input by prompting the user until valid text is entered.  
✅ Counts the occurrences of each vowel and displays the total count.  
✅ Uses a ```Dictionary<char, int>``` to store and efficiently update vowel occurrences.

### How It Works
1. The user enters a text string.
2. The program validates the input.
3. It iterates through each character, updating the count of vowels.
4. The total number of vowels and their individual counts are displayed.

### Example Output

```
Welcome to the Vowel Counter!  
English vowels: a, e, i, o, u.  
Place your text below.  
Text: Hello, this is a test sentence!  

----------------------------------------------------------------------------------------------------
Total number of vowels is: 9.  
Vowel 'a' occurs 1 times.  
Vowel 'e' occurs 5 times.  
Vowel 'i' occurs 2 times.  
Vowel 'o' occurs 1 times.  
Vowel 'u' occurs 0 times.  
```