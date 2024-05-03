using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_к_экзамену
{
    class Figure
    {
        public double Perimetr { set; get; }
        public Figure(Point a,Point b,Point c)
        {
            Perimetr = LiengthSide(a, b) + LiengthSide(b, c) + LiengthSide(c,a);
        }
        public Figure(Point a,Point b,Point c,Point d)
        {
            Perimetr = LiengthSide(a, b) + LiengthSide(b, c) + LiengthSide(c, d)+LiengthSide(d,a);
        }
        public Figure(Point a,Point b,Point c,Point d,Point e)
        {
            Perimetr = LiengthSide(a, b) + LiengthSide(b, c) + LiengthSide(c, d)+LiengthSide(d,e)+LiengthSide(e,a);
        }
        public double LiengthSide(Point A,Point B)
        {
            return Math.Sqrt(Math.Pow(B.X-A.X,2)+Math.Pow(B.Y-A.Y,2));
        }
        public void Perimeter()
        {
            Console.WriteLine($"Периметр равен:{Perimetr}");
        }
    }
}
