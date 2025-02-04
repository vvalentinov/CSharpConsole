# BMI Calculator (C# Console App)

This is a simple BMI Calculator built as a C# console application. It allows users to enter their weight in kilograms and height in meters and centimeters, then calculates their Body Mass Index (BMI). Based on the result, the program provides a color-coded message indicating the BMI category in a user-friendly way.

### 🛠 How It Works

1. The user is prompted to enter their weight in kilograms.
2. The user then enters their height separately in meters and centimeters.
3. The program validates the inputs to ensure they are numerical and within a reasonable range.
4. It calculates BMI using the standard formula: BMI = weight (kg) / height (m²)
5. The program displays the BMI value along with a message and color-coded category (e.g., healthy weight, slightly underweight, above ideal weight).

### 🎨 BMI Categories & Colors

- 🔴 Very Underweight → "You're quite underweight. A health check-up might be a good idea!" (Dark Red)  
- 🟠 Underweight → "You're underweight. Consider a balanced diet to gain strength!" (Red)  
- 🟡 Slightly Underweight → "You're slightly underweight. A little more nutrition could help!" (Yellow)  
- 🟢 Healthy Weight → "Great! You have a healthy weight. Keep it up!" (Green)  
- 🔵 Above Ideal Weight → "You're a bit above the ideal weight. Staying active can help!" (Blue)  
- 🟣 Extra Weight → "Carrying extra weight. A healthy routine could make a difference!" (Magenta)  
- 🟪 High Weight → "Your weight is quite high. Consulting a professional may be helpful!" (Dark Magenta)  
- 🔴 Health Alert → "Health alert! Consider talking to a doctor for guidance." (Dark Red)

### 📊 Input Validation

- Weight: Must be between 1 and 650 kg.  
- Meters: Must be greater than 0.  
- Centimeters: Must be between 1 and 99 cm.