using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практиум_4
{
    internal class Figuries
    {
        public string name;
        public double side1;
        public double side2;
        public Figuries() { }
        public Figuries(string name, double side1, double side2)
        {
            this.name = name;
            this.side1 = side1;
            this.side2 = side2;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"name={name} side1={side1} side2={side2}     ");
        }
        public double S()
        {
            return side1 * side2;
        }
        public double P()
        {
            return side1 + side2+side3;
        }
        public double side3;
        public Figuries(string name, double side1, double side2, double side3) : this(name, side1, side2)
        {
            this.side3 = side3;
        }
    }
}
