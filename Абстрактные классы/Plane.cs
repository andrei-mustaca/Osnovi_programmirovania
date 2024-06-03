using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    internal class Plane:Vehicle
    {
        public int z;
        public int kol_vo;
        public Plane(int x, int y, int price, int scor, int year,int z,int kol_vo) :base(x,y,price,scor,year)
        {
            this.z = z;
            this.kol_vo = kol_vo;
        }
        public override void Print()
        {
            Console.WriteLine($"Широта:{x};Долгота:{y};Высота:{z};Цена:{price};Скорость:{scor} км/ч;Кол-во пассажиров:{kol_vo};Год выпуска:{year}");
        }
    }
}
