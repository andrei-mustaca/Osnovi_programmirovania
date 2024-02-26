using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Square:Figure
    {
        private int side;
        public int Side
        {
            set { side = value; }
            get { return side; }
        }
        public Square(string name,int side):base(name)
        {
            this.side = side;
        }
        public override double Area()
        {
            return Math.Pow(side,2);
        }
        public override double Perimeter()
        {
            return side * 4;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Название:{Name},Длина стороны:{side},Площадь:{Area()},Периметр:{Perimeter()}");
        }
    }
}
