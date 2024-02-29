using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Moldovan:Person
    {
        public Moldovan() { }
        public Moldovan(string name) : base(name)
        { }
        public override void Hello()
        {
            Console.WriteLine($"Буна зиуа,{Name}");
        }
    }
}
