using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    abstract class Person
    {
        public string Name { set; get; }
        public Person() { }
        public Person(string name)
        {
            Name = name;
        }
        public abstract void Hello();
    }
}
