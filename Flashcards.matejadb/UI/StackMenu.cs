using Flashcards.matejadb.Controllers;
using Flashcards.matejadb.UI.Enums;
using Spectre.Console;

namespace Flashcards.matejadb.UI; 
internal class StackMenu {

    private readonly FlashcardMenu _flashcardMenu;
    private readonly StackController _stackController;

    public StackMenu(FlashcardMenu flashcardMenu, StackController stackController) {
        this._flashcardMenu = flashcardMenu;
        this._stackController = stackController;
    }

    public void Run() {
        while (true) {
            Console.Clear();

            var actionChoice = AnsiConsole.Prompt(
                new SelectionPrompt<StackMenuOptions>()
                .Title("Please select an option.")
                .AddChoices(Enum.GetValues<StackMenuOptions>()));

            switch (actionChoice) {
                case StackMenuOptions.Back:
                    return;
                case StackMenuOptions.AddStack:
                    AddStack();
                    break;
                case StackMenuOptions.RemoveStack:
                    break;
                case StackMenuOptions.ManageFlashcards:
                    _flashcardMenu.Run();
                    break;
            }
        }
    }

    private void AddStack() {
        _stackController.AddStack();
    }
}
