using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обобщения
{
    class Point<T>
    {
        private T x;
        public T X { set; get; }
        private T y;
        public T Y { set; get; }
        public Point(T x,T y)
        {
            X = x;
            Y = y;
        }
        public void Print()
        {
            Console.WriteLine($"X={X},Y={Y}");
        }
    }
}
