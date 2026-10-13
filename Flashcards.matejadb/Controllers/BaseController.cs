

using Spectre.Console;

namespace Flashcards.matejadb.Controllers; 
internal class BaseController {
    protected void DisplayMessage(string message, string color = "darkorange") {
        AnsiConsole.MarkupLine($"[{color}]{message}[/]");
    }
}
