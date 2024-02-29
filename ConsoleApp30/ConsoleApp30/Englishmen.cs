using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Englishmen:Person
    {
        public Englishmen() { }
        public Englishmen(string name) : base(name)
        { }
        public override void Hello()
        {
            Console.WriteLine($"Hello,{Name}");
        }
    }
}
