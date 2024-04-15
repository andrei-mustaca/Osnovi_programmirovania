using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3ICompar
{
    internal class Rectangle:Figure
    {
        private int side1;
        private int side2;
        public int Side1
        {
            set { side1 = value; }
            get { return side1; }
        }
        public int Side2
        {
            set { side2 = value; }
            get { return side2; }
        }
        public Rectangle(string name, int side1, int side2) : base(name)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double Area()
        {
            return (side1 + side2) * 2;
        }
        public override double Perimeter()
        {
            return side1 * side2;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Название:{Name},Длина первой стороны:{side1},Длина второй стороны:{side2},Площадь:{Area()},Периметр:{Perimeter()}");
        }
        public static Rectangle Enter()
        {

            Console.Write("Введите первую сторону:");
            int side1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вторую сторону:");
            int side2 = Convert.ToInt32(Console.ReadLine());
            return new Rectangle("прямоугольник", side1, side2);
        }
    }
}
