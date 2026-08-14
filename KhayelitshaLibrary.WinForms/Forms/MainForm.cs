using System;
using KhayelitshaLibrary.WinForms.Configuration;
using KhayelitshaLibrary.WinForms.Repositories;
using KhayelitshaLibrary.WinForms.Models;

namespace KhayelitshaLibrary.WinForms.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //TestDatabaseConnection();
            //TestMemberRepository();
            //TestAddMember();
            //TestUpdateMember();
            //TestDeleteMember();

            //TestBookTitleRepository();
            //TestAddBookTitle();
            //TestUpdateBookTitle();
            //TestDeleteBookTitle();

        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<BookTitleTest>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

        private void TestBookTitleRepository()
        {
            try
            {
                var repository = new BookTitleRepository();

                var books = repository.GetAllBookTitles();

                MessageBox.Show(
                    $"Books loaded successfully!\n\n" +
                    $"Number of books: {books.Count}",
                    "Book Title Repository Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load books.\n\n{ex.Message}",
                    "Book Title Repository Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<AddBookTitleTest>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        private void TestAddBookTitle()
        {
            try
            {
                var repository = new BookTitleRepository();

                var book = new BookTitle
                {
                    Title = "Themba Chronicals",
                    Author = "Themba Kene",
                    ISBN = "9781234567890",
                    Category = "Test"
                };

                repository.AddBookTitle(book);

                MessageBox.Show(
                    "Book added successfully!",
                    "Add Book Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to add book.\n\n{ex.Message}",
                    "Add Book Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<UpdateBookTitleTest>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        private void TestUpdateBookTitle()
        {
            try
            {
                var repository = new BookTitleRepository();

                var books = repository.GetAllBookTitles();

                BookTitle? bookToUpdate = null;

                foreach (var book in books)
                {
                    if (book.ISBN == "9781234567890")
                    {
                        bookToUpdate = book;
                        break;
                    }
                }

                if (bookToUpdate == null)
                {
                    MessageBox.Show(
                        "Test book could not be found.",
                        "Update Book Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Change the book information
                bookToUpdate.Title = "Updated Test Book";
                bookToUpdate.Author = "Updated Author";
                bookToUpdate.ISBN = "9780306406157";
                bookToUpdate.Category = "Updated Category";

                repository.UpdateBookTitle(bookToUpdate);

                MessageBox.Show(
                    $"Book updated successfully!\n\n" +
                    $"Book ID: {bookToUpdate.BookTitleID}\n" +
                    $"New title: {bookToUpdate.Title}",
                    "Update Book Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to update book.\n\n{ex.Message}",
                    "Update Book Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<DeleteBookTitleTest>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        private void TestDeleteBookTitle()
        {
            try
            {
                var repository = new BookTitleRepository();

                var books = repository.GetAllBookTitles();

                BookTitle? bookToDelete = null;

                foreach (var book in books)
                {
                    if (book.BookTitleID == 101)
                    {
                        bookToDelete = book;
                        break;
                    }
                }

                if (bookToDelete == null)
                {
                    MessageBox.Show(
                        "Test book could not be found.",
                        "Delete Book Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                repository.DeleteBookTitle(bookToDelete.BookTitleID);

                MessageBox.Show(
                    $"Book deleted successfully!\n\n" +
                    $"Book ID: {bookToDelete.BookTitleID}\n" +
                    $"Title: {bookToDelete.Title}",
                    "Delete Book Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to delete book.\n\n{ex.Message}",
                    "Delete Book Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        //======================================================================================TestAddingMember=============================================================================================

        private void TestAddMember()
        {
            try
            {
                var repository = new MemberRepository();

                var member = new Member
                {
                    FirstName = "Test",
                    LastName = "Member",
                    Email = "test.member2026@example.com",
                    Age = 25,
                    Address = "Khayelitsha, Cape Town",
                    PhoneNumber = "0821234567",
                    JoinDate = DateOnly.FromDateTime(DateTime.Today)
                };

                repository.AddMember(member);

                MessageBox.Show(
                    "Member added successfully!",
                    "Add Member Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to add member.\n\n{ex.Message}",
                    "Add Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //======================================================================================TestUpdateMember========================================================================================

        private void TestUpdateMember()
        {
            try
            {
                var repository = new MemberRepository();

                var members = repository.GetAllMembers();

                Member memberToUpdate = null;

                foreach (var member in members)
                {
                    if (member.Email == "test.member2026@example.com")
                    {
                        memberToUpdate = member;
                        break;
                    }
                }

                if (memberToUpdate == null)
                {
                    MessageBox.Show(
                        "Test member could not be found.",
                        "Update Member Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                // Change the member's age
                memberToUpdate.Age = 26;

                repository.UpdateMember(memberToUpdate);

                MessageBox.Show(
                    $"Member updated successfully!\n\n" +
                    $"Member ID: {memberToUpdate.MemberID}\n" +
                    $"New age: {memberToUpdate.Age}",
                    "Update Member Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to update member.\n\n{ex.Message}",
                    "Update Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //======================================================================================TestDeleteMember===================================================================================================
        private void TestDeleteMember()
        {
            try
            {
                var repository = new MemberRepository();

                // Delete our test member
                int memberId = 26;

                repository.DeleteMember(memberId);

                MessageBox.Show(
                    $"Member deleted successfully!\n\n" +
                    $"Member ID: {memberId}",
                    "Delete Member Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to delete member.\n\n{ex.Message}",
                    "Delete Member Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        //======================================================================================TestMemberRepository============================================================================================
        private void TestMemberRepository()
        {
            try
            {
                var repository = new MemberRepository();

                var members = repository.GetAllMembers();

                MessageBox.Show(
                    $"Members loaded successfully!\n\nNumber of members: {members.Count}",
                    "Member Repository Test",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load members.\n\n{ex.Message}",
                    "Member Repository Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        //======================================================================================TestDatabaseConnection====================================================================================

        private void TestDatabaseConnection()
        {
            try
            {
                using var connection = DatabaseConnection.CreateConnection();

                connection.Open();

                MessageBox.Show(
                    "Database connection successful!",
                    "Khayelitsha Library",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Database connection failed.\n\n{ex.Message}",
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            MemberForm memberForm = new MemberForm();
            memberForm.Show();
        }

        private void btnLoansReturns_Click(object sender, EventArgs e)
        {
            try
            {
                using (var loanForm = new LoanForm())
                {
                    loanForm.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to open Loan Management.\n\n{ex.Message}",
                    "Loan Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            try
            {
                using var reportForm = new ReportForm();

                reportForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to open the reports form.\n\n{ex.Message}",
                    "Reports Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}