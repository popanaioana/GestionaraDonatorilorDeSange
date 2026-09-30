#  Blood Donor Management System
A Windows Forms application developed in C# for managing blood donor records.
The application provides a simple interface for adding, searching, and deleting donors while storing their information in a SQL Server database. 
# Features\- Add new blood donors

 \- Validate donor information before insertion

 \- Search donors by blood type and Rh factor

 \- Delete donors using their unique ID

 \- Display donor records in a structured table

 \- Store and retrieve donor information using a database

# Technologies

 \- C#

 \- .NET Framework 4.7.2

 \- Windows Forms

 \- SQL Server LocalDB

 \- Visual Studio

 \- ADO.NET / TableAdapters

# Donor Information 

 Each donor record contains:

 \- First name

 \- Last name

 \- Age

 \- Date of birth

 \- Email address

 \- Address

 \- Blood type

 \- Rh factor

# Validation 

 The application performs basic validation before adding donor information, including: 

 \- Required fields

 \- Valid numeric age

 \- Age between 18 and 120

 \- Basic email validation

 \- Valid blood type (`O`, `A`, `B`, `AB`)

 \- Valid Rh factor (`+` or `-`)
 
 Invalid input is handled without terminating the application.

# Project Structure

 \- `MainForm` – main navigation window

 \- `AddForm` – adds and validates new donors

 \- `SearchForm` – searches donors by blood type and Rh factor

 \- `DeleteForm` – removes donors by ID

 \- `DonareSangeDBDataSet` – database dataset and TableAdapter configuration 

# Getting Started

 Requirements

 \- Windows

 \- Visual Studio

 \- .NET Framework 4.7.2

 \- SQL Server LocalDB 

 Running the Application

 1\. Clone the repository.

 2\. Open the solution file in Visual Studio.

 3\. Make sure SQL Server LocalDB is available.

 4\. Build the solution.

 5\. Run the application from Visual Studio. 

# Purpose 

This project was developed as a learning project to practice C# desktop application development, Windows Forms, input validation, database operations, and CRUD-style functionality.

