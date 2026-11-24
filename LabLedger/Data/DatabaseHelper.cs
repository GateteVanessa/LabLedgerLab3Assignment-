using MySqlConnector;
using System.Security.Cryptography;
using System.Text;

namespace LabLedger.Data;

// Uses the MariaDB server bundled with XAMPP. Override LABLEDGER_DB with a
// complete MySQL connection string when the local XAMPP credentials differ.
public static class DatabaseHelper
{
    private const string DatabaseName = "labledger";
    private static readonly string ServerConnectionString = BuildServerConnectionString();
    public static string ConnectionString { get; } = BuildDatabaseConnectionString();

    private static string BuildServerConnectionString()
    {
        var configured = Environment.GetEnvironmentVariable("LABLEDGER_DB");
        if (!string.IsNullOrWhiteSpace(configured))
        {
            var builder = new MySqlConnectionStringBuilder(configured);
            builder.Database = "";
            return builder.ConnectionString;
        }
        return new MySqlConnectionStringBuilder
        {
            Server = "127.0.0.1", Port = 3306, UserID = "root", Password = ""
        }.ConnectionString;
    }

    private static string BuildDatabaseConnectionString()
    {
        var builder = new MySqlConnectionStringBuilder(ServerConnectionString) { Database = DatabaseName };
        return builder.ConnectionString;
    }

    public static MySqlConnection OpenConnection()
    {
        var connection = new MySqlConnection(ConnectionString);
        connection.Open();
        return connection;
    }

    public static void Initialize()
    {
        using (var server = new MySqlConnection(ServerConnectionString))
        {
            server.Open();
            using var createDb = server.CreateCommand();
            createDb.CommandText = $"CREATE DATABASE IF NOT EXISTS `{DatabaseName}` CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci";
            createDb.ExecuteNonQuery();
        }

        using var connection = OpenConnection();
        using (var schema = connection.CreateCommand())
        {
            schema.CommandText = @"
CREATE TABLE IF NOT EXISTS Users(
  Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  Username VARCHAR(100) NOT NULL UNIQUE,
  PasswordHash CHAR(64) NOT NULL,
  Salt CHAR(32) NOT NULL
) ENGINE=InnoDB;
CREATE TABLE IF NOT EXISTS Equipment(
  Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  Name VARCHAR(255) NOT NULL,
  AssetId VARCHAR(100) NOT NULL UNIQUE,
  Category VARCHAR(100) NOT NULL,
  Lab VARCHAR(150) NOT NULL,
  TotalQuantity INT NOT NULL,
  AvailableQuantity INT NOT NULL
) ENGINE=InnoDB;
CREATE TABLE IF NOT EXISTS Loans(
  Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  EquipmentId INT NOT NULL,
  StudentId VARCHAR(100) NOT NULL,
  QuantityBorrowed INT NOT NULL,
  QuantityReturned INT NOT NULL DEFAULT 0,
  BorrowedAt VARCHAR(40) NOT NULL,
  CONSTRAINT FK_Loans_Equipment FOREIGN KEY (EquipmentId) REFERENCES Equipment(Id)
) ENGINE=InnoDB;";
            schema.ExecuteNonQuery();
        }

        using var check = connection.CreateCommand();
        check.CommandText = "SELECT COUNT(*) FROM Users WHERE Username = @username";
        check.Parameters.AddWithValue("@username", "admin");
        if (Convert.ToInt32(check.ExecuteScalar()) == 0)
        {
            var salt = Convert.ToHexString(RandomNumberGenerator.GetBytes(16));
            using var add = connection.CreateCommand();
            add.CommandText = "INSERT INTO Users(Username, PasswordHash, Salt) VALUES(@u,@h,@s)";
            add.Parameters.AddWithValue("@u", "admin");
            add.Parameters.AddWithValue("@h", Hash("admin123", salt));
            add.Parameters.AddWithValue("@s", salt);
            add.ExecuteNonQuery();
        }
    }

    public static string Hash(string password, string salt) =>
        Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(salt + password)));
}
