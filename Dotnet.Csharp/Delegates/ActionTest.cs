using System;

namespace Delegates
{
    public class ActionTest
    {
        private Action<int, int> _actnAdd = (int num1, int num2) =>
        {
            Console.WriteLine("Action Add Result: " + (num1 + num2));
        };
        private Action<int, int> _actnMul = (int num1, int num2) =>
        {
            Console.WriteLine("Action Mul Result: " + (num1 * num2));
        };

        public void ActnAdd(int num1, int num2)
        {
            _actnAdd(num1, num2);
        }

        public void ActnMul(int num1, int num2)
        {
            _actnMul(num1, num2);
        }
    }
}
