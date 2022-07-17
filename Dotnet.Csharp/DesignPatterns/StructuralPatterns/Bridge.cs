using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StructuralPatterns
{
    #region Implementor

    public abstract class DataObject
    {
        public abstract void Add(string name);
        public abstract void Remove(string name);
        public abstract void Update(string oldName, string newName);
        public abstract void ShowAll();
    }

    #endregion

    #region Concrete Implementor

    public class CustomersData : DataObject
    {
        private List<string> customers;

        public CustomersData()
        {
            customers = new List<string>();
        }

        public override void Add(string name)
        {
            customers.Add(name);
        }

        public override void Remove(string name)
        {
            customers.Remove(name);
        }

        public override void ShowAll()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Customer: " + customer);
            }
        }

        public override void Update(string oldName, string newName)
        {
            Remove(oldName);
            Add(newName);
        }
    }

    #endregion

    #region Abstration

    public class CustomersBase
    {
        private DataObject _dataObject;

        public DataObject DataObject
        {
            get { return _dataObject; }
            set { _dataObject = value; }
        }

        public virtual void Add(string name)
        {
            _dataObject.Add(name);
        }

        public virtual void Remove(string name)
        {
            _dataObject.Remove(name);
        }

        public virtual void Update(string oldName, string newName)
        {
            _dataObject.Update(oldName, newName);
        }

        public virtual void ShowAll()
        {
            _dataObject.ShowAll();
        }
    }

    #endregion

    #region Refined Abstration

    public class Customers : CustomersBase
    {
        public override void ShowAll()
        {
            Console.WriteLine("====Customers ShowAll====");
            base.ShowAll();
        }
    }

    #endregion
}
