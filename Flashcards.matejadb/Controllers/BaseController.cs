

using Spectre.Console;

namespace Flashcards.matejadb.Controllers; 
internal class BaseController {
    protected void DisplayMessage(string message, string colour = "darkorange") {
        AnsiConsole.MarkupLine($"[{colour}]{message}[/]");
    }

    protected void DisplayInfo(string message, string colour = "yellow") {
        AnsiConsole.MarkupLine($"[{colour}]{message}[/]");
    }
}
