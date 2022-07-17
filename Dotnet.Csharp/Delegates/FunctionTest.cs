using System;

namespace Delegates
{
    public class FunctionTest
    {
        private Func<int, int, int> _funcAdd = (int num1, int num2) =>
        {
            return num1 + num2;
        };
        private Func<int, int, int> _funcMul = (int num1, int num2) =>
        {
            return num1 * num2;
        };

        public int FuncAdd(int num1, int num2)
        {
            return _funcAdd(num1, num2);
        }

        public int FuncMul(int num1, int num2)
        {
            return _funcMul(num1, num2);
        }
    }
}
