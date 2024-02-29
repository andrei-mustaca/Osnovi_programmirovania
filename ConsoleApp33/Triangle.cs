using System;

namespace ConsoleApp33
{
    internal class Triangle : Figure
    {
        private int side1;
        private int side2;
        private int side3;
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
        public int Side3
        {
            set { side3 = value; }
            get { return side3; }
        }
        public Triangle(string name, int side1, int side2, int side3) : base(name)
        {
            if(side1<side2+side3&&side2<side1+side3&&side3<side1+side2)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }
            else
            {
                this.side1 = 0;
                this.side2 = 0;
                this.side3 = 0;
            }
        }
        public override double Area()
        {
            int p = (side1 + side2 + side3) / 2;
            return Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3));
        }
        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Название:{Name},Длина первой стороны:{side1},Длина второй стороны:{side2},Длина третьей стороны:{side3},Площадь:{Area()},Периметр:{Perimeter()}");
        }
    }
}
