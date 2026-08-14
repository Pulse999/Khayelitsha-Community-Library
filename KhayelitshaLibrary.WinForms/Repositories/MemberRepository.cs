using Npgsql;
using KhayelitshaLibrary.WinForms.Configuration;
using KhayelitshaLibrary.WinForms.Models;

namespace KhayelitshaLibrary.WinForms.Repositories
{
    public class MemberRepository
    {
        //Get all members from the database==============================================================================================================================================================
        public List<Member> GetAllMembers()
        {
            var members = new List<Member>();

            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
                SELECT
                    memberid,
                    firstname,
                    lastname,
                    email,
                    age,
                    address,
                    phonenumber,
                    joindate
                FROM member
                ORDER BY memberid;
            ";

            using var command = new NpgsqlCommand(sql, connection);

            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var member = new Member
                {
                    MemberID = reader.GetInt32(reader.GetOrdinal("memberid")),
                    FirstName = reader.GetString(reader.GetOrdinal("firstname")),
                    LastName = reader.GetString(reader.GetOrdinal("lastname")),
                    Email = reader.GetString(reader.GetOrdinal("email")),
                    Age = reader.GetInt32(reader.GetOrdinal("age")),
                    Address = reader.GetString(reader.GetOrdinal("address")),
                    PhoneNumber = reader.GetString(reader.GetOrdinal("phonenumber")),
                    JoinDate = reader.GetFieldValue<DateOnly>(
                        reader.GetOrdinal("joindate"))
                };

                members.Add(member);
            }

            return members;
        }

        //Add a new member to the database==============================================================================================================================================================

        public void AddMember(Member member)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
        INSERT INTO member
        (
            firstname,
            lastname,
            email,
            age,
            address,
            phonenumber,
            joindate
        )
        VALUES
        (
            @firstname,
            @lastname,
            @email,
            @age,
            @address,
            @phonenumber,
            @joindate
        );
    ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.Add("@firstname", NpgsqlTypes.NpgsqlDbType.Varchar)
                .Value = member.FirstName;

            command.Parameters.Add("@lastname", NpgsqlTypes.NpgsqlDbType.Varchar)
                .Value = member.LastName;

            command.Parameters.Add("@email", NpgsqlTypes.NpgsqlDbType.Varchar)
                .Value = member.Email;

            command.Parameters.Add("@age", NpgsqlTypes.NpgsqlDbType.Integer)
                .Value = member.Age;

            command.Parameters.Add("@address", NpgsqlTypes.NpgsqlDbType.Varchar)
                .Value = member.Address;

            command.Parameters.Add("@phonenumber", NpgsqlTypes.NpgsqlDbType.Varchar)
                .Value = member.PhoneNumber;

            command.Parameters.Add("@joindate", NpgsqlTypes.NpgsqlDbType.Date)
                .Value = member.JoinDate;

            command.ExecuteNonQuery();
        }

        //Update member in the database==============================================================================================================================================================

        public void UpdateMember(Member member)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
        UPDATE member
        SET
            firstname = @firstname,
            lastname = @lastname,
            email = @email,
            age = @age,
            address = @address,
            phonenumber = @phonenumber,
            joindate = @joindate
        WHERE memberid = @memberid;
    ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue("@memberid", member.MemberID);
            command.Parameters.AddWithValue("@firstname", member.FirstName);
            command.Parameters.AddWithValue("@lastname", member.LastName);
            command.Parameters.AddWithValue("@email", member.Email);
            command.Parameters.AddWithValue("@age", member.Age);
            command.Parameters.AddWithValue("@address", member.Address);
            command.Parameters.AddWithValue("@phonenumber", member.PhoneNumber);
            command.Parameters.AddWithValue("@joindate", member.JoinDate);

            command.ExecuteNonQuery();
        }

        // Delete member from the database==============================================================================================================================================================
        public void DeleteMember(int memberId)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
        DELETE FROM member
        WHERE memberid = @memberid;
    ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue("@memberid", memberId);

            command.ExecuteNonQuery();
        }

        // Search member by ID==============================================================================================================================================================
        public Member? SearchMemberById(int memberId)
        {
            using var connection = DatabaseConnection.CreateConnection();

            connection.Open();

            const string sql = @"
        SELECT
            memberid,
            firstname,
            lastname,
            email,
            age,
            address,
            phonenumber,
            joindate
        FROM member
        WHERE memberid = @memberid;
    ";

            using var command = new NpgsqlCommand(sql, connection);

            command.Parameters.AddWithValue("@memberid", memberId);

            using var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return new Member
                {
                    MemberID = reader.GetInt32(
                        reader.GetOrdinal("memberid")),

                    FirstName = reader.GetString(
                        reader.GetOrdinal("firstname")),

                    LastName = reader.GetString(
                        reader.GetOrdinal("lastname")),

                    Email = reader.GetString(
                        reader.GetOrdinal("email")),

                    Age = reader.GetInt32(
                        reader.GetOrdinal("age")),

                    Address = reader.GetString(
                        reader.GetOrdinal("address")),

                    PhoneNumber = reader.GetString(
                        reader.GetOrdinal("phonenumber")),

                    JoinDate = reader.GetFieldValue<DateOnly>(
                        reader.GetOrdinal("joindate"))
                };
            }

            return null;
        }
    }
}