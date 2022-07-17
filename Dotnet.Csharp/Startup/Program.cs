using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Startup
{
    class Program
    {
        private static int timer = 10000;

        static void Main(string[] args)
        {
            //TestDelegates();
            //TestDesignPatterns();
            TestIAAC();
            //TestParallelProgramming();
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        static void TestDesignPatterns()
        {
            DesignPatternsTest dpTest = new DesignPatternsTest();

            dpTest.TestAbstractFactory();
            dpTest.TestBuilder();
            dpTest.TestFactoryMethod();
            dpTest.TestSingleton();
        }

        static void TestParallelProgramming()
        {
            Action<List<string>> performAction = (list) =>
            {
                foreach (var item in list)
                {
                    Console.WriteLine("perform Action: " + item);
                }
            };
            ParallelProgrammingTest ppTest = new ParallelProgrammingTest();

            //ppTest.TestSomeClassMethodsSynchronously();
            //ppTest.TestSomeClassMethodsInThreads();
            ppTest.TestSomeClassMethodsAsynchronously();
            ppTest.TestSomeClassMethodsAsynchronously(performAction);

        }

        static void TestDelegates()
        {
            DelegatesTest delTest = new DelegatesTest();
            delTest.TestFunctions();
            delTest.TestActions();
            delTest.TestPredicates();
        }

        static void TestIAAC()
        {
            IAACTest delTest = new IAACTest();
            delTest.Run();

        }

        static void Process()
        {
            Console.WriteLine("Process started....");
            Task.Delay(timer).Wait();
            Console.WriteLine("Process completed....");
        }

        static async void ProcessAsync()
        {
            Console.WriteLine("ProcessAsync started....");
            await Task.Delay(timer);
            Console.WriteLine("ProcessAsync completed....");
            //return "Hello world!";
        }

        static async Task ProcessAsyncTask()
        {
            Console.WriteLine("ProcessAsyncTask started....");
            await Task.Delay(timer);
            Console.WriteLine("ProcessAsyncTask completed....");
            //return "Hello world!";
        }



    }
}
