using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОбобщенияПракт2
{
    class Triangle<T>
    {
        private Point<T> a;
        public Point<T> A { set; get; }
        private Point<T> b;
        public Point<T> B {set;get;}
        private Point<T> c;
        public Point<T> C { set; get; }
        public Triangle() { }
        public Triangle(T ax,T ay,T bx,T by,T cx,T cy)
        {
            A = new Point<T>(ax,ay);
            B = new Point<T>(bx,by);
            C = new Point<T>(cx, cy);
        }
        public void Print()
        {
            Console.WriteLine($"A={A.X};{A.Y},B={B.X};{B.Y},C={C.X};{C.Y}");
        }
        public double S()
        {
            dynamic a = A;
            dynamic b = B;
            dynamic c = C;
            dynamic ab = Math.Sqrt(Math.Pow(b.X-a.X,2)+Math.Pow(b.Y-a.Y,2));
            dynamic bc = Math.Sqrt(Math.Pow(c.X - b.X, 2) + Math.Pow(c.Y - b.Y, 2));
            dynamic ca = Math.Sqrt(Math.Pow(a.X - c.X, 2) + Math.Pow(a.Y - c.Y, 2));
            dynamic p = (ab+bc+ca) / 3;
            return Math.Sqrt(p*(p-ab)*(p-bc)*(p-ca));
        }
    }
}
