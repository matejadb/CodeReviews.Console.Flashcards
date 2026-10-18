using System;
using Microsoft.Data.SqlClient;
using Flashcards.matejadb.Config;

namespace Flashcards.matejadb.Repositories;

public class DatabaseInitializer
{

	internal void InitializeDatabase() {
        using var connection = new SqlConnection(AppSettings.ConnectionString);
        connection.Open();
        using var command = new SqlCommand(@"
			IF OBJECT_ID('Stacks', 'U') IS NULL 
            CREATE TABLE Stacks (
                Id INT PRIMARY KEY IDENTITY,
                Name NVARCHAR(100) UNIQUE NOT NULL
            );
                
            IF OBJECT_ID('Flashcards', 'U') IS NULL 
            CREATE TABLE Flashcards (
                Id INT PRIMARY KEY IDENTITY,
                StackId INT NOT NULL,
                Question NVARCHAR(255) NOT NULL,
                Answer NVARCHAR(255) NOT NULL,
                FOREIGN KEY (StackId) REFERENCES Stacks(Id) ON DELETE CASCADE
            );
		", connection);
        command.ExecuteNonQuery();
    }
}
