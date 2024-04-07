using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract5
{
    abstract class Goods
    {
        public string Name { set; get; }
        public int Price { set; get; }
        public Goods(string name,int price)
        {
            Name = name;
            Price = price;
        }
        public abstract void Print();
        public abstract void Deadline();
    }
}
