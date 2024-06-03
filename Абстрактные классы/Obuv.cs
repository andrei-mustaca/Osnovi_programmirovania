using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    internal class Obuv:Tovar
    {
        private int kol_vo;
        public int Kol_vo { set; get; }
        private string color;
        public string Color { set; get; }
        public Obuv() { }
        public Obuv(string name, int price,int kol_vo,string color) :base(name,price)
        {
            Kol_vo = kol_vo;
            Color = color;
        }
        public override int Calc()
        {
            return Price * Kol_vo;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Количество:{Kol_vo};Цвет:{Color}");
        }
    }
}
