using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Segment<T>
    {
        private T x1;
        public T X1 { set; get; }
        private T x2;
        public T X2 { set; get; }
        private T y1;
        public T Y1 { set; get; }
        private T y2;
        public T Y2 { set; get; }
        public Segment() { }
        public Segment(T x1,T x2,T y1,T y2)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;
        }
        public void Print()
        {
            Console.WriteLine($"x1={X1};y1={Y1};x2={X2};y2={Y2}");
        }
        public double L()
        {
            return Math.Sqrt(Math.Pow((dynamic)X2-(dynamic)X1,2)+Math.Pow((dynamic)Y2-(dynamic)Y1,2));
        }
    }
}
