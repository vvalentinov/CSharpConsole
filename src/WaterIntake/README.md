# Water Intake Tracker

This is a simple C# console application that allows users to track their daily water intake. The application uses SQLite and ADO.NET to perform CRUD (Create, Read, Update, Delete) operations on a table containing id, date, and litres fields.

## Features

- Add water intake records (date, litres)
- View water intake history
- Update existing records
- Delete records

## Technologies Used

- C#
- ADO.NET
- SQLite

## Table Schema

- id (INTEGER PRIMARY KEY)
- date (TEXT, stores date of intake)
- litres (REAL, stores amount of water in litres)