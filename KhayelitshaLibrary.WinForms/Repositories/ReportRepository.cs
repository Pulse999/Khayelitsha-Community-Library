using System;
using System.Data;
using Npgsql;
using KhayelitshaLibrary.WinForms.Configuration;

namespace KhayelitshaLibrary.WinForms.Repositories
{
    public class ReportRepository
    {
        // =================================================================================================
        // CURRENT AND OVERDUE LOANS REPORT
        // =================================================================================================

        public DataTable GetCurrentAndOverdueLoans()
        {
            var table = new DataTable();

            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                SELECT
                    l.loanid AS ""Loan ID"",
                    l.memberid AS ""Member ID"",
                    m.firstname || ' ' || m.lastname AS ""Member Name"",
                    l.copyid AS ""Copy ID"",
                    bt.title AS ""Book Title"",
                    l.loandate AS ""Loan Date"",
                    l.duedate AS ""Due Date"",
                    CASE
                        WHEN l.duedate < CURRENT_DATE
                            THEN 'Overdue'
                        ELSE 'Current'
                    END AS ""Status""
                FROM loan l
                INNER JOIN member m
                    ON l.memberid = m.memberid
                INNER JOIN bookcopy bc
                    ON l.copyid = bc.copyid
                INNER JOIN booktitle bt
                    ON bc.booktitleid = bt.booktitleid
                WHERE l.returndate IS NULL
                ORDER BY l.duedate;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            using var adapter = new NpgsqlDataAdapter(command);

            adapter.Fill(table);

            return table;
        }


        // =================================================================================================
        // LOANS PER MEMBER REPORT
        // =================================================================================================

        public DataTable GetLoansPerMember()
        {
            var table = new DataTable();

            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                SELECT
                    m.memberid AS ""Member ID"",
                    m.firstname || ' ' || m.lastname AS ""Member Name"",
                    COUNT(l.loanid) AS ""Number of Loans""
                FROM member m
                LEFT JOIN loan l
                    ON m.memberid = l.memberid
                GROUP BY
                    m.memberid,
                    m.firstname,
                    m.lastname
                ORDER BY
                    COUNT(l.loanid) DESC,
                    m.memberid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            using var adapter = new NpgsqlDataAdapter(command);

            adapter.Fill(table);

            return table;
        }
    }
}