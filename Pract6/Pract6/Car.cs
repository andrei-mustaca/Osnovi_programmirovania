using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    class Car:Vehicle
    {
        public int Power { set; get; }
        public Car(int price,int maxspeed,int year,int power):base(price,maxspeed,year)
        {
            Power = power;
        }
        public override void Print()
        {
            Console.WriteLine($"Цена:{Price},Макс.скорость:{Maxspeed},Год выпуска:{Year},Мощность:{Power}");
        }
        public static Car Enter()
        {
            Console.Write("Введите цену:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите макс.скорость:");
            int maxspeed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год выпуска:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите мощность:");
            int power = Convert.ToInt32(Console.ReadLine());
            return new Car(price,maxspeed,year,power);
        }
    }
}
