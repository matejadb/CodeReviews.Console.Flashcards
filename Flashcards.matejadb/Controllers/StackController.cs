
using Flashcards.matejadb.Controllers.Interfaces;
using Flashcards.matejadb.Repositories;
using Flashcards.matejadb.Utils;

namespace Flashcards.matejadb.Controllers; 
internal class StackController : BaseController, IStackController {
    StackRepository _stackRepository = new();

    public void AddStack() {
        var stackName = UserInput.GetStringInputFromUser("stack name");

        if (!_stackRepository.InsertNewStack(stackName)) DisplayInfo("Stack with this name already exists");

        DisplayMessage("Press any Key to continue");
        Console.ReadKey();
    }

    public void RemoveStack() { }
    public void ManageFlashcards() { }
}
