using Flashcards.matejadb.UI.Enums;
using Spectre.Console;

namespace Flashcards.matejadb.UI; 
public class StackMenu {

    private readonly FlashcardMenu flashcardMenu;

    public StackMenu(FlashcardMenu flashcardMenu) {
        this.flashcardMenu = flashcardMenu;
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
                    break;
                case StackMenuOptions.RemoveStack:
                    break;
                case StackMenuOptions.ManageFlashcards:
                    flashcardMenu.Run();
                    break;
            }
        }
    }
}
