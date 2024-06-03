using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    abstract class Tovar
    {
        private string name;
        public string Name { set; get; }
        private int price;
        public int Price { set; get; }
        public Tovar() { }
        public Tovar(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Название:{Name};Цена:{Price}");
        }
        public abstract int Calc();
    }
}
