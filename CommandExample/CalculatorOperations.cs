using System;

namespace CommandExample
{
    public class CalculatorOperations
    {
        private int _curr = 0;

        public void Operation(char operation, int operand)
        {
            switch (operation)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
            Console.WriteLine(
                "Current value = {0,3} (following {1} {2})",
                _curr, operation, operand);
        }
    }
}