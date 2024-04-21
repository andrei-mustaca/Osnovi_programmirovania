using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3ICompar
{
    abstract class Goods:IComparable<Goods>
    {
        public string Name { set; get; }
        public int Price { set; get; }
        public Goods(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public abstract void Print();
        public abstract void Deadline();
        public int CompareTo(Goods goods)
        {
            return Price.CompareTo(goods.Price);
        }
    }
}
