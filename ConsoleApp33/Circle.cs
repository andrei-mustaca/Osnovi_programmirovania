using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    internal class Circle:Figure
    {
        const double PI = 3.14;
        private int radius;
        public int Radius
        {
            set { radius = value; }
            get { return radius; }
        }
        public Circle(string name,int radius):base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return PI*Math.Pow(radius,2);
        }
        public override double Perimeter()
        {
            return 2 * PI * radius;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Название:{Name},Длина радиуса:{radius},Площадь:{Area()},Периметр:{Perimeter()}");
        }
    }
}
