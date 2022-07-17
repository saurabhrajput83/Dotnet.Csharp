using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns
{

    #region Abstract Factory

    public abstract class ContinentFactory
    {
        public abstract Carnivore CreateCarnivore();
        public abstract Herbivore CreateHerbivore();
    }

    #endregion

    #region Concrete Factory

    public class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }

    public class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildbeest();
        }
    }


    #endregion

    #region Abstract Product

    public abstract class Herbivore
    {

    }

    public abstract class Carnivore
    {
        public abstract void Eat(Herbivore obj);
    }

    #endregion

    #region Concrete Product

    public class Wildbeest : Herbivore
    { }

    public class Bison : Herbivore
    { }

    public class Lion : Carnivore
    {
        public override void Eat(Herbivore obj)
        {
            Console.WriteLine(string.Format("{0} eats {1}.",
                this.GetType().Name,
                obj.GetType().Name));
        }
    }

    public class Wolf : Carnivore
    {
        public override void Eat(Herbivore obj)
        {
            Console.WriteLine(string.Format("{0} eats {1}.",
                this.GetType().Name,
                obj.GetType().Name));
        }

    }



    #endregion

    #region Client

    public class AnimalWorld
    {
        private readonly Carnivore _carnivore;
        private readonly Herbivore _herbivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _carnivore = factory.CreateCarnivore();
            _herbivore = factory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }

    #endregion


}
