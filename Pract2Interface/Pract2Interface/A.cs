using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2Interface
{
    class A:IInteface6_1
    {
        public int X { set; get; }
        public int Y { set; get; }
        public A() { }
        public A(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
        public virtual int Add()
        {
            return X + Y;
        }
        public virtual int Sub()
        {
            return X - Y;
        }
        public virtual int Mul()
        {
            return X * Y;
        }
        public virtual int Div()
        {
            return X / Y;
        }
    }
}
