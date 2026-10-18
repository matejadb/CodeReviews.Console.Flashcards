using Flashcards.matejadb.Dtos;
using Microsoft.Data.SqlClient;
using Flashcards.matejadb.Config;

namespace Flashcards.matejadb.Repositories;

public class StackRepository {

    public List<StackDTO> GetAll() {
        var stacks = new List<StackDTO>();

        using var connection = new SqlConnection(AppSettings.ConnectionString);
        connection.Open();

        using var command = new SqlCommand("SELECT Id, Name FROM Stacks ORDER BY Id ASC", connection);
        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            var newStack = new StackDTO();

            newStack.Id = reader.GetInt32(0);
            newStack.Name = reader.GetString(1);

            stacks.Add(newStack);

        }

        return stacks;
    }

    public bool InsertNewStack(string stackName) {
        try {
            using var connection = new SqlConnection(AppSettings.ConnectionString);
            connection.Open();

            using var command = new SqlCommand("INSERT INTO Stacks (Name) VALUES (@name)", connection);
            command.Parameters.AddWithValue("@name", stackName);

            command.ExecuteNonQuery();
        } catch (SqlException ex) when (ex.Number == 2627) {
            return false;
        }

        return true;
    }
}
