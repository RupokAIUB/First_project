# CRUD Application

This is a simple CRUD (Create, Read, Update, Delete) application built using C# and Windows Forms. The application allows you to manage records in a SQL Server database using basic CRUD operations. 

## Features

- **Create**: Insert new records into the database.
- **Read**: Retrieve and display records based on a specified ID.
- **Update**: Modify existing records in the database.
- **Delete**: Remove records from the database based on a specified ID.

## Prerequisites

Before you can run the application, ensure you have the following installed:

- [Visual Studio](https://visualstudio.microsoft.com/) with the .NET desktop development workload.
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) 

## Setup

### Clone the Repository

Clone this repository to your local machine using:

```bash
git clone https://github.com/RupokAIUB/First_project
Database Setup:
1.Create Database: Open SQL Server Management Studio (SSMS) and create a new database named CRUDform.

2.Create Table: Execute the following SQL script to create a table named ut in the CRUDform database:
CREATE TABLE ut (
    ID INT PRIMARY KEY,
    Name VARCHAR(50),
    Semester varchar
);
Configuration
1.Update Connection String: The connection string in the application needs to be updated to match your SQL Server instance. Open the Form1.cs file and modify the connection string in the following methods:
button1_Click,button2_Click,button3_Click,button4_Click
Update the Data Source part of the connection string to match your SQL Server instance name.
2.Build and Run: Open the project in Visual Studio, build the solution, and run the application.
Usage:
1.Create: Enter values into ID, Name, and Semester text boxes and click the "Insert" button to add a new record to the database.
2.Read: Enter an ID into the ID text box and click the "Retrieve" button to fetch and display the record in the DataGridView.
3.Update: Enter the ID of the record you want to update, modify the Name and Semester values, and click the "Update" button.
4.Delete: Enter the ID of the record you want to delete and click the "Delete" button.

