using System;
using System.Collections.Generic;
using Npgsql;
using KhayelitshaLibrary.WinForms.Configuration;
using KhayelitshaLibrary.WinForms.Models;

namespace KhayelitshaLibrary.WinForms.Repositories
{
    public class BookCopyRepository
    {
        // =================================================================================================
        // GET ALL BOOK COPIES
        // =================================================================================================

        public List<BookCopy> GetAllBookCopies()
        {
            var copies = new List<BookCopy>();

            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                SELECT
                    copyid,
                    booktitleid,
                    status
                FROM bookcopy
                ORDER BY copyid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var copy = new BookCopy
                {
                    CopyID = reader.GetInt32(
                        reader.GetOrdinal("copyid")),

                    BookTitleID = reader.GetInt32(
                        reader.GetOrdinal("booktitleid")),

                    Status = reader.GetString(
                        reader.GetOrdinal("status"))
                };

                copies.Add(copy);
            }

            return copies;
        }


        // =================================================================================================
        // GET AVAILABLE BOOK COPIES
        // =================================================================================================

        public List<BookCopy> GetAvailableBookCopies()
        {
            var copies = new List<BookCopy>();

            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                SELECT
                    copyid,
                    booktitleid,
                    status
                FROM bookcopy
                WHERE status = 'Available'
                ORDER BY copyid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var copy = new BookCopy
                {
                    CopyID = reader.GetInt32(
                        reader.GetOrdinal("copyid")),

                    BookTitleID = reader.GetInt32(
                        reader.GetOrdinal("booktitleid")),

                    Status = reader.GetString(
                        reader.GetOrdinal("status"))
                };

                copies.Add(copy);
            }

            return copies;
        }


        // =================================================================================================
        // GET BOOK COPY BY ID
        // =================================================================================================

        public BookCopy? GetBookCopyById(int copyId)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                SELECT
                    copyid,
                    booktitleid,
                    status
                FROM bookcopy
                WHERE copyid = @copyid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@copyid",
                copyId
            );

            using var reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            return new BookCopy
            {
                CopyID = reader.GetInt32(
                    reader.GetOrdinal("copyid")),

                BookTitleID = reader.GetInt32(
                    reader.GetOrdinal("booktitleid")),

                Status = reader.GetString(
                    reader.GetOrdinal("status"))
            };
        }


        // =================================================================================================
        // ADD BOOK COPY
        // =================================================================================================

        public void AddBookCopy(BookCopy copy)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                INSERT INTO bookcopy
                (
                    booktitleid,
                    status
                )
                VALUES
                (
                    @booktitleid,
                    @status
                );
            ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@booktitleid",
                copy.BookTitleID
            );

            command.Parameters.AddWithValue(
                "@status",
                copy.Status
            );

            command.ExecuteNonQuery();
        }


        // =================================================================================================
        // UPDATE BOOK COPY
        // =================================================================================================

        public void UpdateBookCopy(BookCopy copy)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                UPDATE bookcopy
                SET
                    booktitleid = @booktitleid,
                    status = @status
                WHERE copyid = @copyid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@copyid",
                copy.CopyID
            );

            command.Parameters.AddWithValue(
                "@booktitleid",
                copy.BookTitleID
            );

            command.Parameters.AddWithValue(
                "@status",
                copy.Status
            );

            command.ExecuteNonQuery();
        }


        // =================================================================================================
        // DELETE BOOK COPY
        // =================================================================================================

        public void DeleteBookCopy(int copyId)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                DELETE FROM bookcopy
                WHERE copyid = @copyid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue(
                "@copyid",
                copyId
            );

            command.ExecuteNonQuery();
        }

    }
}