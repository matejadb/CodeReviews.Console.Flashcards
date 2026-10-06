using Microsoft.Data.SqlClient;

namespace Flashcards.matejadb {
    internal class Program {
        const string connectionString =
            "Server=matejadb;Database=LOCAL_FLASHCARDS;Trusted_Connection=True;TrustServerCertificate=True;";
        static void Main(string[] args) {
            using var connection = new SqlConnection(connectionString);
            connection.Open();

            using var command = new SqlCommand("SELECT COUNT(*) FROM Stacks", connection);
            var count = (int)command.ExecuteScalar();

            Console.WriteLine($"Connected! Stacks in DB: {count}");
        }
    }
}
