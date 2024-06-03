using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    internal class Car:Vehicle
    {
        public Car(int x, int y, int price, int scor, int year):base(x,y,price,scor,year)
        {
        }
        public override void Print()
        {
            Console.WriteLine($"Широта:{x};Долгота:{y};Цена:{price};Скорость:{scor} км/ч;Год выпуска:{year}");
        }
    }
}
