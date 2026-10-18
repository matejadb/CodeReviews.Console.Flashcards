using Flashcards.matejadb.Repositories;
using Flashcards.matejadb.Enums;
using Flashcards.matejadb.UI;
using Flashcards.matejadb.Controllers;

namespace Flashcards.matejadb;

internal class Program {
    static void Main(string[] args) {
        var _databaseInitializer = new DatabaseInitializer();
        _databaseInitializer.InitializeDatabase();

        var flashcardMenu = new FlashcardMenu();
        var stackController = new StackController();

        var stackMenu = new StackMenu(flashcardMenu, stackController);
        var mainMenu = new MainMenu(stackMenu);

        mainMenu.Run();

    }
}
