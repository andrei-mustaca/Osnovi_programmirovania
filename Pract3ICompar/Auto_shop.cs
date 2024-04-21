using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3ICompar
{
    internal class Auto_shop:IComparable<Auto_shop>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxSpeed { set; get; }
        public int Price { set; get; }
        public int Skidka { set; get; }
        public Auto_shop() { }
        public Auto_shop(int iD, string name, int maxSpeed, int price, int skidka)
        {
            ID = iD;
            Name = name;
            MaxSpeed = maxSpeed;
            Price = price-(price/100*skidka);
            Skidka = skidka;
        }
        public void Print()
        {
            Console.WriteLine($"Идентификатор:{ID},Марка:{Name},Макс.скорость:{MaxSpeed},Цена:{Price},Скидка:{Skidka}");
        }
        public int CompareTo(Auto_shop o) 
        {
            return Price.CompareTo(o.Price);
        }
    }
}
