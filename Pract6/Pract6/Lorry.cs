using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    class Lorry:Vehicle
    {
        public int Max_v { set; get; }
        public Lorry(int price,int maxspeed,int year,int max_v):base(price,maxspeed,year)
        {
            Max_v = max_v;
        }
        public override void Print()
        {
            Console.WriteLine($"Цена:{Price},Макс.скорость:{Maxspeed},Год выпуска:{Year},Макс.грузоподъемность:{Max_v}");
        }
        public static Lorry Enter()
        {
            Console.Write("Введите цену:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите макс.скорость:");
            int maxspeed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год выпуска:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите макс.грузоподъемность:");
            int max_v = Convert.ToInt32(Console.ReadLine());
            return new Lorry(price, maxspeed, year, max_v);
        }
    }
}
