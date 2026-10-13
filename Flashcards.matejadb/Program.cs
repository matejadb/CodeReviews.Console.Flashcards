using Flashcards.matejadb.Repositories;
using Flashcards.matejadb.Enums;
using Flashcards.matejadb.UI;

namespace Flashcards.matejadb;

internal class Program {
    static void Main(string[] args) {
        var flashcardMenu = new FlashcardMenu();

        var stackMenu = new StackMenu(flashcardMenu);

        var mainMenu = new MainMenu(stackMenu);

        mainMenu.Run();

        //var repository = new StackRepository();

        //var InsertionCode = repository.InsertNewStack("Serbian2");

        //switch(InsertionCode) {
        //    case InsertStackResult.Created:
        //        Console.WriteLine("Stack created sucessfully");
        //        break;
        //    case InsertStackResult.Duplicate:
        //        Console.WriteLine("Stack name duplicated. Choose another one");
        //        break;
        //    default:
        //        Console.WriteLine("Unknown error.");
        //        break;
        //}


        //var stacks = repository.GetAll();

        //foreach (var stack in stacks) {
        //    Console.WriteLine($"{stack.Id} {stack.Name}");
        //}


    }
}
