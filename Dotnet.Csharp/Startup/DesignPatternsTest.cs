using DesignPatterns.CreationalPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Startup
{
    public class DesignPatternsTest
    {
        public DesignPatternsTest()
        {

        }

        public void TestAbstractFactory()
        {
            Console.WriteLine("====TestAbstractFactory Starts====");

            ContinentFactory factory1 = new AmericaFactory();
            ContinentFactory factory2 = new AfricaFactory();

            AnimalWorld animalWorld1 = new AnimalWorld(factory1);
            animalWorld1.RunFoodChain();

            AnimalWorld animalWorld2 = new AnimalWorld(factory2);
            animalWorld2.RunFoodChain();

            Console.WriteLine("====TestAbstractFactory Ends====\n");

        }

        public void TestBuilder()
        {
            Console.WriteLine("====TestBuilder Starts====");

            VehicleBuilder vehicleBuilder;
            Shop shop = new Shop();

            vehicleBuilder = new ScooterCycleBuilder();
            shop.Construct(vehicleBuilder);
            vehicleBuilder.Vehicle.Show();

            vehicleBuilder = new MotorCycleBuilder();
            shop.Construct(vehicleBuilder);
            vehicleBuilder.Vehicle.Show();

            vehicleBuilder = new CarBuilder();
            shop.Construct(vehicleBuilder);
            vehicleBuilder.Vehicle.Show();

            Console.WriteLine("====TestBuilder Ends====\n");

        }

        public void TestFactoryMethod()
        {
            Console.WriteLine("====TestFactoryMethod Starts====");

            Document[] documents = new Document[2];
            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (var document in documents)
            {
                Console.WriteLine(string.Format("Document Name: {0}",
                    document.GetType().Name));
                Console.WriteLine("Document Pages:");
                Console.WriteLine("===============");
                foreach (var page in document.Pages)
                {
                    Console.WriteLine(string.Format("Page Name: {0}",
                        page.GetType().Name));
                }
                Console.WriteLine("===============");
            }

            Console.WriteLine("====TestFactoryMethod Ends====\n");

        }

        public void TestSingleton()
        {
            Console.WriteLine("====Singleton Starts====");

            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();
            Console.WriteLine(string.Format("s1=>name:{0},guid:{1}", s1.Name, s1.Guid));
            Console.WriteLine(string.Format("s2=>name:{0},guid:{1}", s2.Name, s2.Guid));
            Console.WriteLine(string.Format("s2=>name:{0},guid:{1}", s2.Name, s2.Guid));

            Console.WriteLine("====Singleton Ends====\n");

        }
    }
}
