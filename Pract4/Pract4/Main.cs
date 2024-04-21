using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    abstract class Main:Interface1
    {
        public string FIO { set; get; }
        public string Fac { set; get; }
        public Main(string fio,string fac)
        {
            FIO = fio;
            Fac = fac;
        }
        public abstract void Print();
        public abstract void RegY();
        public abstract void RegN();
    }
}
