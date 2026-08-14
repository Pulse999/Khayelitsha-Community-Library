using Npgsql;
using KhayelitshaLibrary.WinForms.Configuration;
using KhayelitshaLibrary.WinForms.Models;

namespace KhayelitshaLibrary.WinForms.Repositories
{
    public class BookTitleRepository
    {
        //get all the books
        public List<BookTitle> GetAllBookTitles()
        {
            var books = new List<BookTitle>();

            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                SELECT
                    booktitleid,
                    title,
                    author,
                    isbn,
                    category
                FROM booktitle
                ORDER BY booktitleid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var book = new BookTitle
                {
                    BookTitleID = reader.GetInt32(reader.GetOrdinal("booktitleid")),
                    Title = reader.GetString(reader.GetOrdinal("title")),
                    Author = reader.GetString(reader.GetOrdinal("author")),
                    ISBN = reader.GetString(reader.GetOrdinal("isbn")),
                    Category = reader.GetString(reader.GetOrdinal("category"))
                };

                books.Add(book);
            }

            return books;
        }

        // Add a new book title to the database
        public void AddBookTitle(BookTitle book)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
        INSERT INTO booktitle
        (
            title,
            author,
            isbn,
            category
        )
        VALUES
        (
            @title,
            @author,
            @isbn,
            @category
        );
    ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue("@title", book.Title);
            command.Parameters.AddWithValue("@author", book.Author);
            command.Parameters.AddWithValue("@isbn", book.ISBN);
            command.Parameters.AddWithValue("@category", book.Category);

            command.ExecuteNonQuery();
        }

        // Update book title in the database
        public void UpdateBookTitle(BookTitle book)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
        UPDATE booktitle
        SET
            title = @title,
            author = @author,
            isbn = @isbn,
            category = @category
        WHERE booktitleid = @booktitleid;
    ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue("@booktitleid", book.BookTitleID);
            command.Parameters.AddWithValue("@title", book.Title);
            command.Parameters.AddWithValue("@author", book.Author);
            command.Parameters.AddWithValue("@isbn", book.ISBN);
            command.Parameters.AddWithValue("@category", book.Category);

            command.ExecuteNonQuery();
        }

        // Delete book title from the database
        public void DeleteBookTitle(int bookTitleID)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
        DELETE FROM booktitle
        WHERE booktitleid = @booktitleid;
    ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue("@booktitleid", bookTitleID);

            command.ExecuteNonQuery();
        }
    }
}