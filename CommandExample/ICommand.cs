﻿namespace CommandExample
{
    public interface ICommand
    {
        void Execute();
        void Unexecute();
    }
}