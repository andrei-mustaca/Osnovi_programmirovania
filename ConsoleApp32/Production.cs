using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    abstract class Production
    {
        public string Name {  get; set; }
        public Production() { }
        public Production(string name)
        {
            Name = name;
        }
        public abstract void ShowInfo();
        public abstract double Cost();
    }
}
