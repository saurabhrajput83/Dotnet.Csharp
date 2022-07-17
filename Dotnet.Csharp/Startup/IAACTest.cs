using Delegates;
using IAAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public class IAACTest
    {
        private int num1 = 89;
        private int num2 = 847;
        private int num3;

        public void Run()
        {
            Console.WriteLine("====IAACTest Run Starts====");

            Manager objManager1 = new Manager("Manager 1");
            Developer objDeveloper1 = new Developer("Developer 1");
            Developer objDeveloper2 = new Developer("Developer 2");
            Swipecard objSwipecard = new Swipecard();
            Project objProject1 = new Project("eShop", objManager1);

            objManager1.AddDeveloper(objDeveloper1);
            objManager1.AddDeveloper(objDeveloper2);

            objManager1.Login(objSwipecard);
            objDeveloper1.Login(objSwipecard);
            objDeveloper2.Login(objSwipecard);

            objManager1.DisplayDevelopers();

            objProject1.DisplayProject();

            Console.WriteLine("====IAACTest Run Ends====");
        }

        
    }
}
