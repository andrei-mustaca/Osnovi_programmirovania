using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    abstract class Product
    {
        public string Name { set; get; }
        public int Cost { set; get; }
        public Product(string name,int cost)
        {
            Name = name;
            Cost = cost;
        }
        public abstract void Print();
        public abstract bool ExpirationDate();
    }
}
