using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns
{
    public class Singleton
    {
        private static Singleton _singleton;
        private readonly string _name;
        private readonly Guid _guid;

        public string Name { get { return _name; } }
        public Guid Guid { get { return _guid; } }

        protected Singleton()
        {
            _name = "Singleton";
            _guid = Guid.NewGuid();
        }

        public static Singleton GetInstance()
        {
            // Lazy initialization
            if (_singleton == null)
            {
                _singleton = new Singleton();
            }
            return _singleton;
        }
    }
}
