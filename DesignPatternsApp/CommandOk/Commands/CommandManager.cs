namespace CommandOk.Commands
{
    public static class CommandManager
    {
        public static void Execute(ICommand command)
        {
            if (command.CanExecute()) command.Execute();
        }
    }
}
