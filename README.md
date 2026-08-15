# Khayelitsha Community Library Management System

A C# Windows Forms desktop application for managing the day-to-day
operations of the Khayelitsha Community Library. The application
connects to PostgreSQL and provides member, book, physical-copy,
loan/return, and reporting functionality.

Project Overview
This project was developed as a Software Engineering practical project.
Its purpose is to replace manual library record management with a
structured desktop application backed by a relational PostgreSQL
database.

The system allows library staff to:

Manage library members

Manage book titles

Manage individual physical book copies

Issue books to members

Record book returns

Track copies as Available or On Loan

View current and overdue loans

Generate a loans-per-member report

Search, clear, and refresh records through the Windows Forms
interface

Technologies Used
C#

.NET Windows Forms (WinForms)

PostgreSQL

Npgsql -- PostgreSQL data provider for .NET

Visual Studio

pgAdmin 4

Git / GitHub

Project Structure
KhayelitshaLibrary.WinForms/
├── Configuration/
│   └── DatabaseConnection.cs
├── Forms/
│   ├── MainForm.cs
│   ├── MemberForm.cs
│   ├── BookForm.cs
│   ├── LoanForm.cs
│   └── ReportForm.cs
├── Models/
│   ├── Member.cs
│   ├── BookTitle.cs
│   ├── BookCopy.cs
│   ├── Staff.cs
│   └── Loan.cs
├── Repositories/
│   ├── MemberRepository.cs
│   ├── BookTitleRepository.cs
│   ├── BookCopyRepository.cs
│   ├── StaffRepository.cs
│   ├── LoanRepository.cs
│   └── ReportRepository.cs
├── Database/
│   └── KhayelitshaLibraryDB.sql
├── Program.cs
├── KhayelitshaLibrary.WinForms.csproj
└── KhayelitshaLibrary.WinForms.sln
The exact generated Visual Studio files may vary slightly depending on
the local project configuration.

Main Features
Member Management
The Member Management form provides CRUD functionality for library
members.

Add members

Update member information

Delete members

Search for a member by ID

Clear input fields

Refresh data

Display members in a DataGridView

Member information includes Member ID, first name, last name, email,
age, address, phone number, and join date.

Book Management
The Book Management form manages both book titles and individual
physical copies.

Book Titles
Add book titles

Update book titles

Delete book titles

Clear fields

Display titles in a DataGridView

Each title contains a Book Title ID, title, author, ISBN, and category.

Physical Book Copies
A book title can have one or more physical copies.

Add a physical copy

Update a physical copy

Delete a physical copy

Associate a copy with a book title

Track copy status

Display copies in a DataGridView

The application primarily uses the statuses Available and On Loan.

Loan and Return Management
The Loan Management form connects members, physical book copies, and
staff members.

The system supports:

Issuing an available book copy

Selecting the borrowing member

Selecting the staff member processing the loan

Recording loan and due dates

Recording an optional return date

Updating existing loans

Deleting loans

Viewing loan records

When a book is issued:

Available -> On Loan
When a book is returned:

On Loan -> Available
Database transactions are used for important loan operations so that
loan records and physical-copy statuses remain consistent.

Reports
The reporting module includes:

Current / Overdue Loans

Loans Per Member

The reports use related database tables to display meaningful library
information.

Database Design
The PostgreSQL database contains five main tables:

Member
   |
   +------< Loan >------ Staff
              |
           BookCopy
              |
          BookTitle
member
Stores registered library members.

booktitle
Stores descriptive information about each book title.

bookcopy
Stores individual physical copies. bookcopy.booktitleid references
booktitle.booktitleid.

staff
Stores library staff information.

loan
Stores lending transactions and references:

member.memberid

bookcopy.copyid

staff.staffid

returndate is nullable because active loans have not yet been
returned.

SQL Database Script
The repository includes:

Database/KhayelitshaLibraryDB.sql
The script contains table creation, primary keys, foreign keys,
NOT NULL constraints, CHECK constraints, sample data, sample loan
records, verification queries, and report queries.

Application Design
Repository Pattern
Database access is separated from the Windows Forms interface through
repository classes.

MemberForm -> MemberRepository -> PostgreSQL
BookForm   -> BookTitleRepository / BookCopyRepository -> PostgreSQL
LoanForm   -> LoanRepository -> PostgreSQL
ReportForm -> ReportRepository -> PostgreSQL
This separation makes the application easier to understand and maintain
because database logic is kept separate from user-interface logic.

Transaction-Based Loan Processing
Loan operations can affect more than one database record. Issuing a
book, for example, requires both creating a loan and changing the
physical copy to On Loan.

These related operations are performed in a PostgreSQL transaction. If
one operation fails, the transaction can be rolled back instead of
leaving the database in an inconsistent state.

The same approach is used when updating or deleting loans where
book-copy availability must also be maintained.

Validation and Error Handling
The application includes:

Required-field validation

Numeric ID validation

Member selection validation

Book-copy selection validation

Staff selection validation

Due-date validation

Return-date validation

Book availability validation

Delete confirmation dialogs

Exception handling with try/catch

Parameterized SQL commands

Requirements
To run the project, install:

Visual Studio with .NET desktop development support

PostgreSQL

pgAdmin 4 or another PostgreSQL administration tool

Npgsql NuGet package

Database Setup
Install PostgreSQL.

Create a PostgreSQL database for the project.

Open KhayelitshaLibraryDB.sql in pgAdmin 4.

Run the script against the project database.

Verify that member, booktitle, bookcopy, staff, and loan
exist.

Configure DatabaseConnection.cs for your local PostgreSQL
environment.

Security: Do not commit real database passwords or private
credentials to a public GitHub repository.

Running the Application
Clone or download the repository.

Open the .sln file in Visual Studio.

Restore the NuGet packages.

Confirm PostgreSQL is running.

Configure the database connection.

Build the solution.

Run the application.

Example Test Cases
Test Action Expected Result

TC01 Add a valid member Member is inserted and
displayed

TC02 Update a member Member details are
updated

TC03 Delete a member Confirmation appears
and member is deleted
when permitted

TC04 Add a book title Book title is stored
and displayed

TC05 Add a physical copy Copy is associated with
the selected title

TC06 Issue an available book Loan is created and
copy becomes On Loan

TC07 Return a book Return date is recorded
and copy becomes
Available

Key Learning Outcomes
This project demonstrates:

Object-oriented programming with C#

Windows Forms UI development

PostgreSQL relational database design

CRUD operations

Primary and foreign key relationships

Parameterized SQL queries

Database transactions

Data validation

Exception handling

Repository-based separation of database logic

SQL joins and aggregate reporting

Git-based source control

Future Improvements
Possible improvements include authentication, role-based permissions,
advanced book/member searching, automatic overdue fine calculations,
reservations, overdue email reminders, report export, dashboard
statistics, and improved UI styling.

Academic Project
This application was developed as an educational Software Engineering
project demonstrating C# Windows Forms development, PostgreSQL
integration, CRUD operations, relational database design, validation,
transaction handling, and reporting.

License
This project is intended primarily for educational and portfolio
purposes.
