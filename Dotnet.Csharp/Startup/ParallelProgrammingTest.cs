using DesignPatterns.CreationalPatterns;
using ParallelProgramming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public class ParallelProgrammingTest
    {
        public ParallelProgrammingTest()
        {

        }

        public void TestSomeClassMethodsSynchronously()
        {
            Console.WriteLine("====TestSomeClassMethodsSynchronously Starts====");

            SomeClass someClass = new SomeClass();
            someClass.RunMethodsSynchronously();

            Console.WriteLine("====TestSomeClassMethodsSynchronously Ends====\n");
        }

        public void TestSomeClassMethodsInThreads()
        {
            Console.WriteLine("====TestSomeClassMethodsInThreads Starts====");

            SomeClass someClass = new SomeClass();
            someClass.RunMethodsInThreads();

            Console.WriteLine("====TestSomeClassMethodsInThreads Ends====\n");

        }

        public void TestSomeClassMethodsAsynchronously()
        {
            Console.WriteLine("====TestSomeClassMethodsAsynchronously Starts====");

            SomeClass someClass = new SomeClass();
            someClass.RunMethodsAsynchronously();

            Console.WriteLine("====TestSomeClassMethodsAsynchronously Ends====\n");
        }

        public void TestSomeClassMethodsAsynchronously(Action<List<string>> continuationTask)
        {
            Console.WriteLine("====TestSomeClassMethodsAsynchronouslyV2 Starts====");

            SomeClass someClass = new SomeClass();
            someClass.RunMethodsAsynchronously(continuationTask);

            Console.WriteLine("====TestSomeClassMethodsAsynchronouslyV2 Ends====\n");
        }

    }
}
