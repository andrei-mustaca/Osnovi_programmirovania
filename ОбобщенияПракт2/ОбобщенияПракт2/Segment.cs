using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОбобщенияПракт2
{
    class Segment<T>
    {
        private Point<T> a;
        public Point<T> A { set; get; }
        private Point<T> b;
        public Point<T> B { set; get; }
        public Segment() { }
        public Segment(T ax,T ay,T bx,T by)
        {
            A = new Point<T>(ax,ay);
            B = new Point<T>(bx,by);
        }
        public void Print()
        {
            Console.WriteLine($"A={A.X};{A.Y},B={B.X};{B.Y}");
        }
        public double L()
        {
            dynamic a = A;
            dynamic b = B;
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }
    }
}
