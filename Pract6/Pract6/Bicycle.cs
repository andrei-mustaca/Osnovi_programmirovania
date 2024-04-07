using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    class Bicycle:Vehicle
    {
        public int Kol_vo { set; get; }
        public Bicycle(int price,int maxspeed,int year,int kol_vo):base(price,maxspeed,year)
        {
            Kol_vo = kol_vo;
        }
        public override void Print()
        {
            Console.WriteLine($"Цена:{Price},Макс.скорость:{Maxspeed},Год выпуска:{Year},Кол-во пассажиров:{Kol_vo}");
        }
        public static Bicycle Enter()
        {
            Console.Write("Введите цену:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите макс.скорость:");
            int maxspeed = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите год выпуска:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во пассажиров:");
            int kol_vo = Convert.ToInt32(Console.ReadLine());
            return new Bicycle(price, maxspeed, year, kol_vo);
        }
    }
}
