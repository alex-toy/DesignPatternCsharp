﻿namespace CommandOk.Commands
{
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
    }
}
