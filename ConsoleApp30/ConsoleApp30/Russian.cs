using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Russian:Person
    {
        public Russian() { }
        public Russian(string name):base(name)
        {}
        public override void Hello()
        {
            Console.WriteLine($"Привет,{Name}");
        }
    }
}
