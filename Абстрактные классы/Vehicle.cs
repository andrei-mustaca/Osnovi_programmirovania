using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    abstract class Vehicle
    {
        public int x;
        public int y;
        public int price;
        public int scor;
        public int year;
        public Vehicle() { }
        public Vehicle(int x, int y, int price, int scor, int year)
        {
            this.x = x;
            this.y = y;
            this.price = price;
            this.scor = scor;
            this.year = year;
        }
        public abstract void Print();
    }
}
