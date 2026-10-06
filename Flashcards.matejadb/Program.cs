using Flashcards.matejadb.Data;
using Flashcards.matejadb.Enums;

namespace Flashcards.matejadb;

internal class Program {
    const string connectionString =
        "Server=matejadb;Database=LOCAL_FLASHCARDS;Trusted_Connection=True;TrustServerCertificate=True;";
    static void Main(string[] args) {
        var repository = new StackRepository(connectionString);

        var InsertionCode = repository.InsertNewStack("Serbian2");

        switch(InsertionCode) {
            case InsertStackResult.Created:
                Console.WriteLine("Stack created sucessfully");
                break;
            case InsertStackResult.Duplicate:
                Console.WriteLine("Stack name duplicated. Choose another one");
                break;
            default:
                Console.WriteLine("Unknown error.");
                break;
        }


        var stacks = repository.GetAll();

        foreach (var stack in stacks) {
            Console.WriteLine($"{stack.Id} {stack.Name}");
        }


    }
}
