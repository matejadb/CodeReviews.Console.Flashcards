using Flashcards.matejadb.Enums;
using Flashcards.matejadb.Models;
using Microsoft.Data.SqlClient;
using Flashcards.matejadb.Config;

namespace Flashcards.matejadb.Repositories;

public class StackRepository {

    public List<Stack> GetAll() {
        var stacks = new List<Stack>();

        using var connection = new SqlConnection(AppSettings.ConnectionString);
        connection.Open();

        using var command = new SqlCommand("SELECT Id, Name FROM Stacks ORDER BY Id ASC", connection);
        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            var newStack = new Stack();

            newStack.Id = reader.GetInt32(0);
            newStack.Name = reader.GetString(1);

            stacks.Add(newStack);

        }

        return stacks;
    }

    public InsertStackResult InsertNewStack(string stackName) {
        try {
            using var connection = new SqlConnection(AppSettings.ConnectionString);
            connection.Open();

            using var command = new SqlCommand("INSERT INTO Stacks (Name) VALUES (@name)", connection);
            command.Parameters.AddWithValue("@name", stackName);

            command.ExecuteNonQuery();
        } catch (SqlException ex) when (ex.Number == 2627) {
            return InsertStackResult.Duplicate;
        }

        return InsertStackResult.Created;
    }
}
