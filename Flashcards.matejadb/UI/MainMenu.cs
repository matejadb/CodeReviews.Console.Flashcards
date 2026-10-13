using Flashcards.matejadb.UI.Enums;
using Spectre.Console;

namespace Flashcards.matejadb.UI; 
public class MainMenu {

    private readonly StackMenu stackMenu;
    public MainMenu(StackMenu stackMenu) {
        this.stackMenu = stackMenu;
    }

    public void Run() {

        var programRunning = true;

        while(programRunning) {
            Console.Clear();

            var actionChoice = AnsiConsole.Prompt(
                new SelectionPrompt<MainMenuOptions>()
                .Title("Please select an option.")
                .AddChoices(Enum.GetValues<MainMenuOptions>()));

            switch (actionChoice) {
                case MainMenuOptions.Exit:
                    programRunning = false;
                    break;
                case MainMenuOptions.ManageStacks:
                    stackMenu.Run();
                    break;
                case MainMenuOptions.Study:
                    break;
            }
        }
    }
}
