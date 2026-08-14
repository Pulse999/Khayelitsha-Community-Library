using System;
using System.Collections.Generic;
using Npgsql;
using NpgsqlTypes;
using KhayelitshaLibrary.WinForms.Configuration;
using KhayelitshaLibrary.WinForms.Models;

namespace KhayelitshaLibrary.WinForms.Repositories
{
    public class LoanRepository
    {
        // =================================================================================================
        // GET ALL LOANS
        // =================================================================================================

        public List<Loan> GetAllLoans()
        {
            var loans = new List<Loan>();

            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                SELECT
                    loanid,
                    memberid,
                    copyid,
                    staffid,
                    loandate,
                    duedate,
                    returndate
                FROM loan
                ORDER BY loanid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var loan = new Loan
                {
                    LoanID = reader.GetInt32(
                        reader.GetOrdinal("loanid")),

                    MemberID = reader.GetInt32(
                        reader.GetOrdinal("memberid")),

                    CopyID = reader.GetInt32(
                        reader.GetOrdinal("copyid")),

                    StaffID = reader.GetInt32(
                        reader.GetOrdinal("staffid")),

                    LoanDate = reader.GetFieldValue<DateOnly>(
                        reader.GetOrdinal("loandate")),

                    DueDate = reader.GetFieldValue<DateOnly>(
                        reader.GetOrdinal("duedate")),

                    ReturnDate = reader.IsDBNull(
                        reader.GetOrdinal("returndate"))
                        ? null
                        : reader.GetFieldValue<DateOnly>(
                            reader.GetOrdinal("returndate"))
                };

                loans.Add(loan);
            }

            return loans;
        }


        // =================================================================================================
        // GET LOAN BY ID
        // =================================================================================================

        public Loan? GetLoanById(int loanId)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                SELECT
                    loanid,
                    memberid,
                    copyid,
                    staffid,
                    loandate,
                    duedate,
                    returndate
                FROM loan
                WHERE loanid = @loanid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.Add(
                "@loanid",
                NpgsqlDbType.Integer
            ).Value = loanId;

            using var reader = command.ExecuteReader();

            if (!reader.Read())
            {
                return null;
            }

            return new Loan
            {
                LoanID = reader.GetInt32(
                    reader.GetOrdinal("loanid")),

                MemberID = reader.GetInt32(
                    reader.GetOrdinal("memberid")),

                CopyID = reader.GetInt32(
                    reader.GetOrdinal("copyid")),

                StaffID = reader.GetInt32(
                    reader.GetOrdinal("staffid")),

                LoanDate = reader.GetFieldValue<DateOnly>(
                    reader.GetOrdinal("loandate")),

                DueDate = reader.GetFieldValue<DateOnly>(
                    reader.GetOrdinal("duedate")),

                ReturnDate = reader.IsDBNull(
                    reader.GetOrdinal("returndate"))
                    ? null
                    : reader.GetFieldValue<DateOnly>(
                        reader.GetOrdinal("returndate"))
            };
        }


        // =================================================================================================
        // ADD LOAN
        // =================================================================================================

        public void AddLoan(Loan loan)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                // -----------------------------------------------------------------------------------------
                // Mark the book copy as "On Loan"
                // -----------------------------------------------------------------------------------------

                const string updateCopySql = @"
            UPDATE bookcopy
            SET status = 'On Loan'
            WHERE copyid = @copyid
              AND status = 'Available';
        ";

                using var updateCopyCommand =
                    new NpgsqlCommand(updateCopySql, connection, transaction);

                updateCopyCommand.Parameters.Add(
                    "@copyid",
                    NpgsqlDbType.Integer
                ).Value = loan.CopyID;

                int rowsUpdated = updateCopyCommand.ExecuteNonQuery();

                // If no row was updated, the copy either doesn't exist
                // or is no longer available.
                if (rowsUpdated == 0)
                {
                    throw new InvalidOperationException(
                        "The selected book copy is no longer available."
                    );
                }


                // -----------------------------------------------------------------------------------------
                // Insert the loan
                // -----------------------------------------------------------------------------------------

                const string insertLoanSql = @"
            INSERT INTO loan
            (
                memberid,
                copyid,
                staffid,
                loandate,
                duedate,
                returndate
            )
            VALUES
            (
                @memberid,
                @copyid,
                @staffid,
                @loandate,
                @duedate,
                @returndate
            );
        ";

                using var insertLoanCommand =
                    new NpgsqlCommand(insertLoanSql, connection, transaction);

                insertLoanCommand.Parameters.Add(
                    "@memberid",
                    NpgsqlDbType.Integer
                ).Value = loan.MemberID;

                insertLoanCommand.Parameters.Add(
                    "@copyid",
                    NpgsqlDbType.Integer
                ).Value = loan.CopyID;

                insertLoanCommand.Parameters.Add(
                    "@staffid",
                    NpgsqlDbType.Integer
                ).Value = loan.StaffID;

                insertLoanCommand.Parameters.Add(
                    "@loandate",
                    NpgsqlDbType.Date
                ).Value = loan.LoanDate;

                insertLoanCommand.Parameters.Add(
                    "@duedate",
                    NpgsqlDbType.Date
                ).Value = loan.DueDate;

                insertLoanCommand.Parameters.Add(
                    "@returndate",
                    NpgsqlDbType.Date
                ).Value = loan.ReturnDate.HasValue
                    ? loan.ReturnDate.Value
                    : DBNull.Value;

                insertLoanCommand.ExecuteNonQuery();


                // -----------------------------------------------------------------------------------------
                // Commit transaction
                // -----------------------------------------------------------------------------------------

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }


        // =================================================================================================
        // UPDATE LOAN
        // =================================================================================================

        public void UpdateLoan(Loan loan)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                // -------------------------------------------------------------
                // 1. Get the original loan information
                // -------------------------------------------------------------

                const string getOldLoanSql = @"
            SELECT copyid
            FROM loan
            WHERE loanid = @loanid;
        ";

                int oldCopyID;

                using (var getOldLoanCommand = new NpgsqlCommand(
                    getOldLoanSql,
                    connection,
                    transaction))
                {
                    getOldLoanCommand.Parameters.Add(
                        "@loanid",
                        NpgsqlDbType.Integer
                    ).Value = loan.LoanID;

                    var result = getOldLoanCommand.ExecuteScalar();

                    if (result == null)
                    {
                        throw new Exception("Loan could not be found.");
                    }

                    oldCopyID = Convert.ToInt32(result);
                }


                // -------------------------------------------------------------
                // 2. Update the loan
                // -------------------------------------------------------------

                const string updateLoanSql = @"
            UPDATE loan
            SET
                memberid = @memberid,
                copyid = @copyid,
                staffid = @staffid,
                loandate = @loandate,
                duedate = @duedate,
                returndate = @returndate
            WHERE loanid = @loanid;
        ";

                using (var updateLoanCommand = new NpgsqlCommand(
                    updateLoanSql,
                    connection,
                    transaction))
                {
                    updateLoanCommand.Parameters.Add(
                        "@loanid",
                        NpgsqlDbType.Integer
                    ).Value = loan.LoanID;

                    updateLoanCommand.Parameters.Add(
                        "@memberid",
                        NpgsqlDbType.Integer
                    ).Value = loan.MemberID;

                    updateLoanCommand.Parameters.Add(
                        "@copyid",
                        NpgsqlDbType.Integer
                    ).Value = loan.CopyID;

                    updateLoanCommand.Parameters.Add(
                        "@staffid",
                        NpgsqlDbType.Integer
                    ).Value = loan.StaffID;

                    updateLoanCommand.Parameters.Add(
                        "@loandate",
                        NpgsqlDbType.Date
                    ).Value = loan.LoanDate;

                    updateLoanCommand.Parameters.Add(
                        "@duedate",
                        NpgsqlDbType.Date
                    ).Value = loan.DueDate;

                    updateLoanCommand.Parameters.Add(
                        "@returndate",
                        NpgsqlDbType.Date
                    ).Value = loan.ReturnDate.HasValue
                        ? loan.ReturnDate.Value
                        : DBNull.Value;

                    updateLoanCommand.ExecuteNonQuery();
                }


                // -------------------------------------------------------------
                // 3. If the book copy changed,
                //    make the OLD copy available again
                // -------------------------------------------------------------

                if (oldCopyID != loan.CopyID)
                {
                    const string makeOldCopyAvailableSql = @"
                UPDATE bookcopy
                SET status = 'Available'
                WHERE copyid = @copyid;
            ";

                    using var oldCopyCommand = new NpgsqlCommand(
                        makeOldCopyAvailableSql,
                        connection,
                        transaction);

                    oldCopyCommand.Parameters.Add(
                        "@copyid",
                        NpgsqlDbType.Integer
                    ).Value = oldCopyID;

                    oldCopyCommand.ExecuteNonQuery();
                }


                // -------------------------------------------------------------
                // 4. Update the CURRENT copy status
                // -------------------------------------------------------------

                string newStatus;

                if (loan.ReturnDate.HasValue)
                {
                    newStatus = "Available";
                }
                else
                {
                    newStatus = "On Loan";
                }

                const string updateCopyStatusSql = @"
            UPDATE bookcopy
            SET status = @status
            WHERE copyid = @copyid;
        ";

                using (var copyStatusCommand = new NpgsqlCommand(
                    updateCopyStatusSql,
                    connection,
                    transaction))
                {
                    copyStatusCommand.Parameters.Add(
                        "@status",
                        NpgsqlDbType.Varchar
                    ).Value = newStatus;

                    copyStatusCommand.Parameters.Add(
                        "@copyid",
                        NpgsqlDbType.Integer
                    ).Value = loan.CopyID;

                    copyStatusCommand.ExecuteNonQuery();
                }


                // -------------------------------------------------------------
                // 5. Everything succeeded
                // -------------------------------------------------------------

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }


        // =================================================================================================
        // DELETE LOAN
        // =================================================================================================

        public void DeleteLoan(int loanId)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            using var transaction = connection.BeginTransaction();

            try
            {
                // -------------------------------------------------------------
                // 1. Get the book copy associated with the loan
                // -------------------------------------------------------------

                const string getCopySql = @"
            SELECT copyid
            FROM loan
            WHERE loanid = @loanid;
        ";

                int copyID;

                using (var getCopyCommand = new NpgsqlCommand(
                    getCopySql,
                    connection,
                    transaction))
                {
                    getCopyCommand.Parameters.Add(
                        "@loanid",
                        NpgsqlDbType.Integer
                    ).Value = loanId;

                    var result = getCopyCommand.ExecuteScalar();

                    if (result == null)
                    {
                        throw new Exception("Loan could not be found.");
                    }

                    copyID = Convert.ToInt32(result);
                }


                // -------------------------------------------------------------
                // 2. Delete the loan
                // -------------------------------------------------------------

                const string deleteLoanSql = @"
            DELETE FROM loan
            WHERE loanid = @loanid;
        ";

                using (var deleteLoanCommand = new NpgsqlCommand(
                    deleteLoanSql,
                    connection,
                    transaction))
                {
                    deleteLoanCommand.Parameters.Add(
                        "@loanid",
                        NpgsqlDbType.Integer
                    ).Value = loanId;

                    deleteLoanCommand.ExecuteNonQuery();
                }


                // -------------------------------------------------------------
                // 3. Make the book copy available again
                // -------------------------------------------------------------

                const string updateCopySql = @"
            UPDATE bookcopy
            SET status = 'Available'
            WHERE copyid = @copyid;
        ";

                using (var updateCopyCommand = new NpgsqlCommand(
                    updateCopySql,
                    connection,
                    transaction))
                {
                    updateCopyCommand.Parameters.Add(
                        "@copyid",
                        NpgsqlDbType.Integer
                    ).Value = copyID;

                    updateCopyCommand.ExecuteNonQuery();
                }


                // -------------------------------------------------------------
                // 4. Everything succeeded
                // -------------------------------------------------------------

                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
                throw;
            }
        }
    }
}