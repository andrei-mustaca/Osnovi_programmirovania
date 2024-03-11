using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    abstract class Figure
    {
        public string Name
        { get; set; }
        public int R1
        { set; get; }
        public int H
        { set; get; }
        public Figure(string name, int r1, int h)
        {
            Name = name;
            R1 = r1;
            H = h;
        }
        public abstract double S();
        public abstract double V();
    }
}
