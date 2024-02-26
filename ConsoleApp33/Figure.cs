using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    abstract class Figure
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public Figure(string name)
        {
            this.name = name;
        }
       
        public abstract double Area();
        public abstract double Perimeter();
        public virtual void Print(){}

    }
}
