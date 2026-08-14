using Npgsql;
using KhayelitshaLibrary.WinForms.Configuration;
using KhayelitshaLibrary.WinForms.Models;

namespace KhayelitshaLibrary.WinForms.Repositories
{
    public class StaffRepository
    {
        // =================================================================================================
        // GET ALL STAFF
        // =================================================================================================

        public List<Staff> GetAllStaff()
        {
            var staffMembers = new List<Staff>();

            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                SELECT
                    staffid,
                    firstname,
                    lastname,
                    phonenumber,
                    email
                FROM staff
                ORDER BY staffid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var staff = new Staff
                {
                    StaffID = reader.GetInt32(
                        reader.GetOrdinal("staffid")),

                    FirstName = reader.GetString(
                        reader.GetOrdinal("firstname")),

                    LastName = reader.GetString(
                        reader.GetOrdinal("lastname")),

                    PhoneNumber = reader.GetString(
                        reader.GetOrdinal("phonenumber")),

                    Email = reader.GetString(
                        reader.GetOrdinal("email"))
                };

                staffMembers.Add(staff);
            }

            return staffMembers;
        }
    }
}