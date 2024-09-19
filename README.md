Student Information CRUD application
Project Overview
This project demonstrates how to implement CRUD (Insert,Update, Delete,Search) operations using C# and SQL Server within a Windows Forms Application. It provides a user-friendly interface for managing student records.
Table of Contents
Technologies Used
C#: Core programming language

.NET Framework/Core: Application framework

Entity Framework: ORM for database access

SQL Server or SQLite: Database (choose one based on my project)

Visual Studio: IDE for development

Prerequisites
Visual Studio 2022 or later

SQL Server (Express or any version)

SQL Server Management Studio (SSMS)
Features
Add New Students: Users can input student details such as  ID,  Name, and Semester. When the "Insert" button is clicked, the new student is added to the list and the database.

View/Search Student Information: The application displays all student records in a grid format, showing the  ID, name, and Semester.

Update Student Information: Users can select an existing student from the grid and update their details using the "Update" button. This will modify the selected information in the database.

Delete  Records: Select a student from the grid and click the "Delete" button to remove their record from the system. A confirmation can be implemented to avoid accidental deletions.

Search : Users can search for a student by Student ID, Student Name, or Age using the "Search" button, and the grid will update to show only the relevant records.
Set Up SQL Server Database:
Open SQL Server Management Studio (SSMS) and connect to your SQL Server instance.

Create the Database:

Open the .sql file located in folder.
Copy the queries from the .sql file and execute them in your new database to set up the schema and initial data.
Use Ctrl+F to search for connectionString within the project files.
SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUFJAO\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
Create a Table for Student Information:

CREATE TABLE Students (

Id INT PRIMARY KEY IDENTITY(1,1),
Name NVARCHAR(100) NOT NULL,
Semester varchar NOT NULL
); GO

This table will store StudentId, Name, and Age.

Create a C# Windows Forms Application:

Open Visual Studio.
Create a New Project:

Select C# > Windows Forms App (.NET Framework).
Choose a project name and location.
Design Your Form:

Add text boxes for Id, Name, and Semester.
Add buttons for Insert, Update, Delete, and Search.
Add a DataGridView to display student records.
Add SQL Server Connection: To connect your application to the SQL Server database, you need to configure a connection string.

Install SQL Server NuGet Package (optional if not already available):

In Solution Explorer, right-click on the project and select Manage NuGet Packages.
Search for System.Data.SqlClient and install it.
Set up the Connection String in your C# code: In your code-behind file (e.g., Form1.cs), define the connection string:

string connectionString = "Data Source=YOUR_SERVER_NAME;Initial Catalog=StudentDB;Integrated Security=True;";
Replace (YOUR_SERVER_NAME) with the actual name of your SQL Server (you can find this in SSMS).
C# Code Implementation
insert data function sample
private void button1_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUFJAO\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
    con.Open();
    SqlCommand cmd = new SqlCommand("insert into ut values (@ID,@Name,@Semester)",con);
    cmd.Parameters.AddWithValue("@ID",int.Parse(textBox1.Text));
    cmd.Parameters.AddWithValue("@Name",textBox2.Text);
    cmd.Parameters.AddWithValue("@Semester",double.Parse (textBox3.Text));
    cmd.ExecuteNonQuery();
    con.Close();
    MessageBox.Show("Successfully inserted");
}
Update data function sample
 private void button2_Click(object sender, EventArgs e)
 {
     SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUFJAO\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
     con.Open();
     SqlCommand cmd = new SqlCommand("update ut set Name=@Name,Semester=@Semester where ID=@ID", con);
     cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
     cmd.Parameters.AddWithValue("@Name", textBox2.Text);
     cmd.Parameters.AddWithValue("@Semester", double.Parse(textBox3.Text));
     cmd.ExecuteNonQuery();
     con.Close();
     MessageBox.Show("Successfully Updated");
 }
 Delete Operation
 private void button3_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUFJAO\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
    con.Open();
    SqlCommand cmd = new SqlCommand("delete from ut where ID=@ID",con);
    cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
    cmd.ExecuteNonQuery();
    con.Close();
    MessageBox.Show("Successfully Deleted");

}
Search Operation
private void button4_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection("Data Source=DESKTOP-MKUFJAO\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True");
    con.Open();
    SqlCommand cmd = new SqlCommand("select * from ut where ID=@ID", con);
    cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
    SqlDataAdapter da = new SqlDataAdapter(cmd);
    DataTable dt = new DataTable();
    da.Fill(dt);
    dataGridView1.DataSource = dt;
    
}
User Flow
When the application is opened, existing records are displayed in the DataGridView.
Users can:
Insert: new records by clicking the "Insert" button and submitting the form.
Delete: records by selecting a row and confirming deletion.
Update: user can update any data from data grid view.
Challenges and Considerations
Error Handling: Implement error handling for database connection failures or invalid inputs.
Build and Run the Application:
Open the project in Visual Studio, build it, and run the application.
How to Run the Project
Clone the Repository: Clone this repository to your local machine.
git clone (https://github.com/RupokAIUB/First_project.git)
Set Up the Database: Configure your SQL Server or SQLite database and update the connection according to the script.sql file.
Build the Project: Open the project in Visual Studio and build the solution.
Run the Application: Once built, run the application and manage records through the Windows Forms interface.
