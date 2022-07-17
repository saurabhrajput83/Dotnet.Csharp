using System;

namespace Delegates
{
    public class PredicateTest
    {
        private Predicate<int> _predGreaterThan100 = (int num) =>
        {
            return (num > 100);
        };
        private Predicate<int> _predLessThan100 = (int num) =>
        {
            return (num < 100);
        };

        public bool PredGreaterThan100(int num)
        {
            return _predGreaterThan100(num);
        }

        public bool PredLessThan100(int num)
        {
            return _predLessThan100(num);
        }
    }
}
