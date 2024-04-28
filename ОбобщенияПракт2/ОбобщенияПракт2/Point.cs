using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОбобщенияПракт2
{
    class Point<T>
    {
        public T X { set; get; }
        public T Y { set; get; }
        public Point() { }
        public Point(T x,T y)
        {
            X = x;
            Y = y;
        }
    }
}
