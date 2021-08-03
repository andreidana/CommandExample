using System;
using System.Collections.Generic;

namespace CommandExample
{
    public class User
    {
        private readonly CalculatorOperations _calculator = new CalculatorOperations();
        private readonly List<ICommand> _commands = new List<ICommand>();
        private int _current = 0;

        public void Redo(int levels)
        {
            Console.WriteLine("\n---- Redo {0} levels ", levels);

            for (var i = 0; i < levels; i++)
            {
                if (_current >= _commands.Count - 1) continue;
                var command = _commands[_current++];
                command.Execute();
            }
        }

        public void Undo(int levels)
        {
            Console.WriteLine("\n---- Undo {0} levels ", levels);

            for (var i = 0; i < levels; i++)
            {
                if (_current <= 0) continue;
                var command = _commands[--_current] as ICommand;
                command.Undo();
            }
        }

        public void Compute(char @operator, int operand)
        {
            var command = new Calculator(_calculator, @operator, operand);
            command.Execute();

            _commands.Add(command);
            _current++;
        }
    }
}