using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Triangle<T>
    {
        private T a;
        public T A { set; get; }
        private T b;
        public T B { set; get; }
        private T c;
        public T C { set; get; }
        public Triangle() { }
        public Triangle(T a,T b,T c)
        {
            if((dynamic)a<(dynamic)b+(dynamic)c&&(dynamic)b<(dynamic)a+(dynamic)c&&(dynamic)c<(dynamic)a+(dynamic)b)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                Console.WriteLine("Треугольника не существует");
                A = (dynamic)0;
                B = (dynamic)0;
                C = (dynamic)0;
            }
        }
        public void Print()
        {
            Console.WriteLine($"a={A};b={B};c={C}");
        }
        public double Area()
        {
            double p = (double)((dynamic)A + (dynamic)B +(dynamic) C) / 2;
            return Math.Sqrt((dynamic)p-((dynamic)A-(dynamic)p)*((dynamic)B - (dynamic)p)*((dynamic)C - (dynamic)p));
        }
    }
}
