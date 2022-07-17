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
            //DesignPatternsTest dpTest = new DesignPatternsTest();
            //dpTest.TestAbstractFactory();
            //dpTest.TestBuilder();
            //dpTest.TestFactoryMethod();
            //dpTest.TestSingleton();

            ParallelProgrammingTest ppTest = new ParallelProgrammingTest();
            Action<List<string>> performAction = (list) =>
            {
                foreach (var item in list)
                {
                    Console.WriteLine("perform Action: " + item);
                }
            };

            DateTime dtStart = DateTime.Now;

            ppTest.TestSomeClassMethodsSynchronously();
            ppTest.TestSomeClassMethodsInThreads();
            ppTest.TestSomeClassMethodsAsynchronously();
            ppTest.TestSomeClassMethodsAsynchronously(performAction);

            DateTime dtEnd = DateTime.Now;
            //Console.WriteLine(string.Format("Result: {0}", result));
            Console.WriteLine(string.Format("Time Taken: {0}", dtEnd - dtStart));
            //Process();
            //ProcessAsync();
            //await ProcessAsyncTask();

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
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
