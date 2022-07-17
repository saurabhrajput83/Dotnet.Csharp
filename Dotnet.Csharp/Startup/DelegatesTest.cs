using Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public class DelegatesTest
    {
        private int num1 = 89;
        private int num2 = 847;
        private int num3;

        public void TestFunctions()
        {
            Console.WriteLine("====FunctionTest Starts====");

            FunctionTest funcTest = new FunctionTest();

            num3 = funcTest.FuncAdd(num1, num2);
            Console.WriteLine("Function Add Result: " + num3);

            num3 = funcTest.FuncMul(num1, num2);
            Console.WriteLine("Function Mul Result: " + num3);

            Console.WriteLine("====FunctionTest Run Ends====");
        }

        public void TestActions()
        {
            Console.WriteLine("====ActionTest Starts====");

            ActionTest actnTest = new ActionTest();

            actnTest.ActnAdd(num1, num2);

            actnTest.ActnMul(num1, num2);

            Console.WriteLine("====ActionTest Ends====");
        }

        public void TestPredicates()
        {
            Console.WriteLine("====TestPredicates Starts====");

            PredicateTest predTest = new PredicateTest();
            bool result;

            result = predTest.PredLessThan100(num1);
            Console.WriteLine("Predicate LessThan100 Result: " + result);

            result = predTest.PredGreaterThan100(num2);
            Console.WriteLine("Predicate GreaterThan100 Result: " + result);

            Console.WriteLine("====TestPredicates Ends====");
        }
    }
}
