using System;
using System.Collections.Generic;

namespace IAAC
{
    public abstract class Employee
    {
        private string _employeeName;

        public Employee(string employeeName)
        {
            _employeeName = employeeName;
        }

        public string EmployeeName
        {
            get { return _employeeName; }
        }

        /// <summary>
        /// Association
        /// </summary>
        /// <param name="objSwipecard"></param>
        public void Login(Swipecard objSwipecard)
        {
            //// Association
            objSwipecard.Swipe(this);
        }
    }

    /// <summary>
    /// Inheritance
    /// </summary>
    public class Developer : Employee
    {
        public Developer(string developerName) : base(developerName)
        {

        }
    }

    /// <summary>
    /// Inheritance
    /// </summary>
    public class Manager : Employee
    {
        private List<Developer> _developers;
        public Manager(string managerName) : base(managerName)
        {
            _developers = new List<Developer>();
        }

        public List<Developer> Developers { get { return _developers; } }

        /// <summary>
        /// Aggregation
        /// </summary>
        /// <param name="objDeveloper"></param>
        public void AddDeveloper(Developer objDeveloper)
        {
            _developers.Add(objDeveloper);
        }

        /// <summary>
        /// 
        /// </summary>
        public void DisplayDevelopers()
        {
            int counter = 1;
            foreach (var developer in _developers)
            {
                Console.WriteLine(counter + ". " + developer.EmployeeName);
                counter++;
            }
        }

    }

    /// <summary>
    /// 
    /// </summary>
    public class Project
    {
        private string _projectName;
        private Manager _objManager;
        public Project(string projectName, Manager objManager)
        {
            _projectName = projectName;
            _objManager = objManager;
        }

        public void DisplayProject()
        {
            Console.WriteLine("====Projects Details====");
            Console.WriteLine("Project Name: " + _projectName);
            Console.WriteLine("Project Manager Name: " + _objManager.EmployeeName);
        }
    }

    public class Swipecard
    {
        /// <summary>
        /// Association
        /// </summary>
        /// <param name="objEmployee"></param>
        public void Swipe(Employee objEmployee)
        {
            Console.WriteLine(string.Format("{0} (Name: {1}) login.",
                objEmployee.GetType().Name,
                objEmployee.EmployeeName));
        }
    }


}
