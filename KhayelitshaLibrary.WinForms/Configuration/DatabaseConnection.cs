using Npgsql;

namespace KhayelitshaLibrary.WinForms.Configuration
{
    public static class DatabaseConnection
    {
        private static readonly string ConnectionString =
            $"Host=localhost;" +
            $"Port=5432;" +
            $"Database=KhayelitshaLibraryDB;" +
            $"Username=postgres;" +
            $"Password={Environment.GetEnvironmentVariable("KHAYELITSHA_DB_PASSWORD")}";

        public static NpgsqlConnection CreateConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }
    }
}