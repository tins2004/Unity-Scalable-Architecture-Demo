using System.Collections.Generic;

public static class CommandInvoker
{
    private static Stack<ICommand> undoStack = new Stack<ICommand>();
    private static Stack<ICommand> redoStack = new Stack<ICommand>();

    public static void ExecuteCommand(ICommand command)
    {
        command.Execute();
        undoStack.Push(command);
    }

    public static void UndoCommand()
    {
        if (undoStack.Count > 0)
        {
            ICommand activeCommand = undoStack.Pop();

            activeCommand.Undo();
            redoStack.Push(activeCommand);
        }
    }

    public static void ReduCommand()
    {
        if (redoStack.Count > 0)
        {
            ICommand activeCommand = redoStack.Pop();

            activeCommand.Execute();
            undoStack.Push(activeCommand);
        }
    }
}
