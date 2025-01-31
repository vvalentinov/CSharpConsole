# 💧 Water Intake Tracker 🚰

### A Simple Yet Powerful Console App for Tracking Daily Water Consumption

Water Intake Tracker is a C# console application designed to help users monitor their daily water intake. Staying hydrated is essential for good health, and this application makes it easy to log, update, delete, and view your water consumption records using an SQLite database.  

Whether you’re aiming to build a healthier hydration habit or just want to keep track of your daily intake, this tool provides a simple yet effective way to manage your water consumption.

### ✨ Features
🔹 Log Water Intake – Easily enter the date and amount of water consumed (in liters).  
🔹 View All Records – Display all logged water intake data in a structured format.  
🔹 Update Entries – Modify an existing record by changing the date or amount.  
🔹 Delete Records – Remove an unwanted water intake entry.  
🔹 User-Friendly Console UI – Simple, interactive menu-driven navigation.  
🔹 Data Persistence with SQLite – Keeps records stored securely and efficiently.  
🔹 Error Handling & Validation – Ensures correct input formats for dates and numbers. 

### 🛠 Technologies Used

🔹 C# (.NET) – Core programming language.  
🔹 SQLite – Lightweight database for storing water intake records.  
🔹 Async/Await – Ensures efficient database operations without blocking execution.  
🔹 Object-Oriented Design – Modular and structured code organization.

### 🛡️ Data Validation & Error Handling

The application includes robust input validation to ensure that data is stored correctly.
- **Date Validation**: Only allows dates in the correct ```yyyy-MM-dd``` format.
- **Water Intake Validation**: Accepts only numeric values with up to three decimal places.
- **Record ID Validation**: Ensures that only valid record IDs are used for updates or deletions.