using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    internal class Ship:Vehicle
    {
        public int kol_vo;
        public string port;
        public Ship() { }
        public Ship(int x, int y, int price, int scor, int year, int kol_vo,string port) :base(x, y, price, scor, year)
        {
            this.kol_vo = kol_vo;
            this.port = port;
        }
        public override void Print()
        {
            Console.WriteLine($"Широта:{x};Долгота:{y};Цена:{price};Скорость:{scor} км/ч;Кол-во пассажиров:{kol_vo};Название порта:{port};Год выпуска:{year}");
        }
    }
}
