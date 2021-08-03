using System;

namespace CommandExample
{
    public class CalculatorOperations
    {
        private int _current;

        public void Operation(char operation, int operand)
        {
            switch (operation)
            {
                case '+': _current += operand; break;
                case '-': _current -= operand; break;
                case '*': _current *= operand; break;
                case '/': _current /= operand; break;
            }
            Console.WriteLine(
                "Current value = {0,3} (following {1} {2})",
                _current, operation, operand);
        }
    }
}