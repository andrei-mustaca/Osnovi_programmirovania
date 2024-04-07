using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    abstract class Vehicle
    {
        public int Price { set; get; }
        public int Maxspeed { set; get; }
        public int Year { set; get; }
        public Vehicle(int price,int maxspeed,int year)
        {
            Price = price;
            Maxspeed = maxspeed;
            Year = year;
        }
        public abstract void Print();
    }
}
