using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flashcards.matejadb.Utils; 
public static class UserInput {
    
    public static string GetStringInputFromUser(string message) {
        var userInput = AnsiConsole.Ask<string>($"Enter the [darkorange]{message}[/]");

        return userInput;
    }
}
