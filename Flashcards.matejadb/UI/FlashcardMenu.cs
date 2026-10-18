
using Flashcards.matejadb.UI.Enums;
using Spectre.Console;

namespace Flashcards.matejadb.UI; 
internal class FlashcardMenu {

    public FlashcardMenu() { }

    public void Run() {
        while (true) {
            Console.Clear();

            var actionChoice = AnsiConsole.Prompt(
                new SelectionPrompt<FlashcardMenuOptions>()
                .Title("Please select an option.")
                .AddChoices(Enum.GetValues<FlashcardMenuOptions>()));

            switch (actionChoice) {
                case FlashcardMenuOptions.Back:
                    return;
                case FlashcardMenuOptions.AddFlashcards:
                    break;
                case FlashcardMenuOptions.RemoveFlashcards:
                    break;
                case FlashcardMenuOptions.ViewFlashcards:
                    break;
            }
        }
    }
}
