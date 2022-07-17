using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProgramming
{
    public class SomeClass
    {
        private int timer1 = 5000;
        private int timer2 = 6000;
        private int timer3 = 7000;

        public void RunMethodsSynchronously()
        {
            SomeMethod1();
            SomeMethod2();
        }

        public void RunMethodsInThreads()
        {
            Thread t1 = new Thread(new ThreadStart(SomeMethod1));
            t1.Start();
            Thread t2 = new Thread(new ThreadStart(SomeMethod2));
            t2.Start();
        }

        public void RunMethodsAsynchronously()
        {
            SomeMethod1Async();
            SomeMethod2Async();
        }

        public void RunMethodsAsynchronously(Action<List<string>> continuationTask)
        {
            SomeMethod1Async(continuationTask);
            SomeMethod2Async(continuationTask);
        }

        public void RunMethodsTasks()
        {
            SomeMethod1Async();
            SomeMethod2Async();
        }

        private void SomeMethod1()
        {
            Console.WriteLine("SomeMethod1 Enter");
            Task.Delay(timer1).Wait();
            Console.WriteLine("SomeMethod1 Exit");

        }

        private void SomeMethod2()
        {
            Console.WriteLine("SomeMethod2 Enter");
            Task.Delay(timer2).Wait();
            Console.WriteLine("SomeMethod2 Exit");
        }

        private async void SomeMethod1Async()
        {
            Console.WriteLine("SomeMethod1Async Enter");
            await Task.Delay(timer1);
            Console.WriteLine("SomeMethod1Async Exit");

        }

        private async void SomeMethod2Async()
        {
            Console.WriteLine("SomeMethod2Async Enter");
            await Task.Delay(timer2);
            Console.WriteLine("SomeMethod2Async Exit");
            //return "Hello world!";
        }

        private async void SomeMethod1Async(Action<List<string>> continuationTask)
        {
            Console.WriteLine("SomeMethod1AsyncV2 Enter");
            List<string> list = new List<string>();
            list.Add("U.S.");
            list.Add("U.K.");
            await (Task.Delay(timer1)).ContinueWith((task) =>
            {
                continuationTask(list);
            });
            Console.WriteLine("SomeMethod1AsyncV2 Exit");

        }

        private async void SomeMethod2Async(Action<List<string>> continuationTask)
        {
            Console.WriteLine("SomeMethod2AsyncV2 Enter");
            List<string> list = new List<string>();
            list.Add("U.S.");
            list.Add("U.K.");
            await (Task.Delay(timer2)).ContinueWith((task) =>
            {
                continuationTask(list);
            });
            Console.WriteLine("SomeMethod2AsyncV2 Exit");
        }

    }


}
