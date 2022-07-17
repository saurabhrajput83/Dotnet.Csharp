using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns
{

    #region Builder

    public abstract class VehicleBuilder
    {
        protected Vehicle _vehicle;

        public Vehicle Vehicle { get { return _vehicle; } }

        public abstract void BuildDoors();
        public abstract void BuildEngine();
        public abstract void BuildFrame();
        public abstract void BuildWheels();


    }

    #endregion

    #region ConcreteBuilder

    public class ScooterCycleBuilder : VehicleBuilder
    {
        public ScooterCycleBuilder()
        {
            _vehicle = new Vehicle("Scooter");
        }

        public override void BuildDoors()
        {
            _vehicle["Doors"] = "0";
        }

        public override void BuildEngine()
        {
            _vehicle["Engine"] = "100 cc";
        }

        public override void BuildFrame()
        {
            _vehicle["Frame"] = "Scooter Frame";
        }

        public override void BuildWheels()
        {
            _vehicle["Wheels"] = "2";
        }
    }

    public class MotorCycleBuilder : VehicleBuilder
    {

        public MotorCycleBuilder()
        {
            _vehicle = new Vehicle("MotorCycle");
        }

        public override void BuildDoors()
        {
            _vehicle["Doors"] = "0";
        }

        public override void BuildEngine()
        {
            _vehicle["Engine"] = "150 cc";
        }

        public override void BuildFrame()
        {
            _vehicle["Frame"] = "MotorCycle Frame";
        }

        public override void BuildWheels()
        {
            _vehicle["Wheels"] = "2";
        }
    }

    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            _vehicle = new Vehicle("Car");
        }

        public override void BuildDoors()
        {
            _vehicle["Doors"] = "4";
        }

        public override void BuildEngine()
        {
            _vehicle["Engine"] = "250 cc";
        }

        public override void BuildFrame()
        {
            _vehicle["Frame"] = "Car Frame";
        }

        public override void BuildWheels()
        {
            _vehicle["Wheels"] = "4";
        }
    }

    #endregion

    #region Director

    public class Shop
    {

        public void Construct(VehicleBuilder vehicleBuilder)
        {
            vehicleBuilder.BuildDoors();
            vehicleBuilder.BuildEngine();
            vehicleBuilder.BuildFrame();
            vehicleBuilder.BuildWheels();
        }


    }

    #endregion

    #region Product

    public class Vehicle
    {
        private readonly string _vehicleType;
        private Dictionary<string, string> _vehicleParts;

        public Vehicle(string vehicleType)
        {
            _vehicleType = vehicleType;
            _vehicleParts = new Dictionary<string, string>();
        }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <returns></returns>
        public string this[string key]
        {
            get { return _vehicleParts[key]; }
            set { _vehicleParts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Vehicle Details:");
            Console.WriteLine(string.Format("Vehicle Type: {0}", _vehicleType));
            Console.WriteLine(string.Format("Doors: {0}", _vehicleParts["Doors"]));
            Console.WriteLine(string.Format("Engine: {0}", _vehicleParts["Engine"]));
            Console.WriteLine(string.Format("Frame: {0}", _vehicleParts["Frame"]));
            Console.WriteLine(string.Format("Wheels: {0}", _vehicleParts["Wheels"]));
            Console.WriteLine("---------------");
        }
    }

    #endregion

}
