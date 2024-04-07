using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    abstract class Software
    {
        public string Manufacturer { set; get; }
        public string Name { set; get; }
        public Software(string manufacturer,string name)
        {
            Manufacturer = manufacturer;
            Name = name;
        }
        public abstract void Print();
        public abstract void Usable();
    }
}
