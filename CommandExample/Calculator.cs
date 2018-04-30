using System;

namespace CommandExample
{
    public class Calculator : ICommand
    {
        private char _operation;
        private int _operand;
        private readonly CalculatorOperations _calculator;

        public Calculator(CalculatorOperations calculator,char operation, int operand)
        {
            this._calculator = calculator;
            this._operation = operation;
            this._operand = operand;
        }

        public char Operator
        {
            set => _operation = value;
        }

        public int Operand
        {
            set => _operand = value;
        }

        public void Execute()
        {
            _calculator.Operation(_operation, _operand);
        }

        public void Unexecute()
        {
            _calculator.Operation(Undo(_operation), _operand);
        }

        private char Undo(char @operator)
        {
            switch (@operator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("@operation");
            }
        }
    }
}