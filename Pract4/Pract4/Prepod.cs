using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class Prepod:Main
    {
        public string Kaf { set; get; }
        public Prepod(string fio,string fac,string kaf):base(fio,fac)
        {
            Kaf = kaf;
        }
        public override void Print()
        {
            Console.WriteLine($"ФИО:{FIO},Факультет:{Fac},Кафедра:{Kaf}");
        }
        public override void RegN()
        {}
        public override void RegY()
        {
            Console.WriteLine($"Пропуск для преподователя {FIO} обновлен");
        }
    }
}
