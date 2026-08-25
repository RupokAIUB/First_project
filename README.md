# Student Information CRUD Application

A simple **Student Information Management System** built using **C# Windows Forms and SQL Server**. This project demonstrates the implementation of basic **CRUD operations** — Create, Read, Update, Delete, and Search.

## 📌 Project Overview

This application provides a user-friendly interface for managing student information. Users can add new student records, update existing information, delete records, search for students, and view student data in a `DataGridView`.

The project uses **C#**, **Windows Forms**, **ADO.NET**, and **SQL Server** for database management.

---

## ✨ Features

* ➕ **Insert Student Information**
* 📋 **View Student Records**
* ✏️ **Update Student Information**
* 🗑️ **Delete Student Records**
* 🔍 **Search Student by ID**
* 📊 Display student information using **DataGridView**
* 🗄️ Store and manage data using **SQL Server**

---

## 🛠️ Technologies Used

| Technology                | Description                                |
| ------------------------- | ------------------------------------------ |
| **C#**                    | Core programming language                  |
| **Windows Forms**         | Used to build the graphical user interface |
| **.NET Framework**        | Application framework                      |
| **ADO.NET**               | Used for database connectivity             |
| **SQL Server**            | Database management system                 |
| **System.Data.SqlClient** | Used for SQL Server operations             |
| **Visual Studio**         | Development environment                    |

---

## 📋 Prerequisites

Before running this project, make sure you have the following installed:

* Visual Studio 2022 or later
* SQL Server Express or another version of SQL Server
* SQL Server Management Studio (SSMS)

---

## 🗄️ Database Setup

### Step 1: Create the Database

Open **SQL Server Management Studio (SSMS)** and create a new database.

```sql
CREATE DATABASE CRUDform;
```

### Step 2: Create the Table

Select the `CRUDform` database and run the following SQL query:

```sql
CREATE TABLE ut (
    ID INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Semester FLOAT NOT NULL
);
```

This table will store the following student information:

* ID
* Name
* Semester

---

## 🔌 Configure Database Connection

Open the project in Visual Studio and find the database connection string.

Example:

```csharp
SqlConnection con = new SqlConnection(
    "Data Source=DESKTOP-MKUFJAO\\SQLEXPRESS;Initial Catalog=CRUDform;Integrated Security=True"
);
```

⚠️ **Important:** Replace the server name with your own SQL Server instance name.

For example:

```csharp
Data Source=YOUR_SERVER_NAME;Initial Catalog=CRUDform;Integrated Security=True;
```

You can find your SQL Server name in **SQL Server Management Studio (SSMS)**.

---

# ⚙️ CRUD Operations

## ➕ Insert Student Information

Users can add a new student by entering:

* Student ID
* Student Name
* Semester

After clicking the **Insert** button, the information will be stored in the SQL Server database.

Example implementation:

```csharp
private void button1_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection(
        "Data Source=YOUR_SERVER_NAME;Initial Catalog=CRUDform;Integrated Security=True"
    );

    con.Open();

    SqlCommand cmd = new SqlCommand(
        "INSERT INTO ut VALUES (@ID, @Name, @Semester)", con
    );

    cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
    cmd.Parameters.AddWithValue("@Semester", double.Parse(textBox3.Text));

    cmd.ExecuteNonQuery();

    con.Close();

    MessageBox.Show("Successfully Inserted");
}
```

---

## ✏️ Update Student Information

Users can update an existing student's information using their Student ID.

```csharp
private void button2_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection(
        "Data Source=YOUR_SERVER_NAME;Initial Catalog=CRUDform;Integrated Security=True"
    );

    con.Open();

    SqlCommand cmd = new SqlCommand(
        "UPDATE ut SET Name=@Name, Semester=@Semester WHERE ID=@ID",
        con
    );

    cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));
    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
    cmd.Parameters.AddWithValue("@Semester", double.Parse(textBox3.Text));

    cmd.ExecuteNonQuery();

    con.Close();

    MessageBox.Show("Successfully Updated");
}
```

---

## 🗑️ Delete Student Information

Users can delete a student record by entering or selecting the Student ID and clicking the **Delete** button.

```csharp
private void button3_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection(
        "Data Source=YOUR_SERVER_NAME;Initial Catalog=CRUDform;Integrated Security=True"
    );

    con.Open();

    SqlCommand cmd = new SqlCommand(
        "DELETE FROM ut WHERE ID=@ID",
        con
    );

    cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

    cmd.ExecuteNonQuery();

    con.Close();

    MessageBox.Show("Successfully Deleted");
}
```

---

## 🔍 Search Student Information

Users can search for a student using the Student ID.

The search result will be displayed in the `DataGridView`.

```csharp
private void button4_Click(object sender, EventArgs e)
{
    SqlConnection con = new SqlConnection(
        "Data Source=YOUR_SERVER_NAME;Initial Catalog=CRUDform;Integrated Security=True"
    );

    con.Open();

    SqlCommand cmd = new SqlCommand(
        "SELECT * FROM ut WHERE ID=@ID",
        con
    );

    cmd.Parameters.AddWithValue("@ID", int.Parse(textBox1.Text));

    SqlDataAdapter da = new SqlDataAdapter(cmd);

    DataTable dt = new DataTable();

    da.Fill(dt);

    dataGridView1.DataSource = dt;

    con.Close();
}
```

---

# 🖥️ User Flow

When the application starts, users can manage student records through the Windows Forms interface.

### Users can:

1. **Insert** a new student record.
2. **View** student information in the DataGridView.
3. **Update** an existing student's information.
4. **Delete** a student record.
5. **Search** for a student using their ID.

---

# 📂 Project Structure

```text
First_project/
│
├── Form1.cs
├── Form1.Designer.cs
├── Program.cs
├── First_project.csproj
└── README.md
```

---

# ▶️ How to Run the Project

### 1. Clone the Repository

Clone the repository to your local machine:

```bash
git clone https://github.com/nahidrupok/First_project.git
```

### 2. Open the Project

Open the project or solution file using **Visual Studio**.

### 3. Set Up the Database

* Open SQL Server Management Studio.
* Create the `CRUDform` database.
* Create the `ut` table using the SQL query provided above.

### 4. Update the Connection String

Find the following connection string in the project:

```csharp
Data Source=YOUR_SERVER_NAME;
Initial Catalog=CRUDform;
Integrated Security=True;
```

Replace `YOUR_SERVER_NAME` with your SQL Server instance name.

### 5. Build the Project

In Visual Studio:

```text
Build → Build Solution
```

### 6. Run the Application

Press:

```text
F5
```

The application will start, and you can begin managing student information.

---

# ⚠️ Challenges and Considerations

Some possible improvements for the project include:

* Add proper error handling for database connection failures.
* Validate user input before inserting data.
* Prevent duplicate Student IDs.
* Add confirmation before deleting a record.
* Improve search functionality.
* Use `try-catch` blocks for exception handling.
* Store the connection string in a configuration file instead of directly inside the code.

---

# 🚀 Future Improvements

Future versions of this project may include:

* Student registration validation
* Search by student name
* Search by semester
* Confirmation dialog before deletion
* Better error handling
* Login system
* Improved user interface
* Configuration-based database connection
* Export student information

---

# 👨‍💻 Author

**Nahid Rupok**

GitHub: https://github.com/nahidrupok

---

## 📄 License

This project is created for **educational and learning purposes**.
