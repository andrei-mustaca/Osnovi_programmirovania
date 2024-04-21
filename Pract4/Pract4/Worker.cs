using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class Worker:Main
    {
        public DateTime Date1 { set; get; }
        public DateTime Date2 { set; get; }
        public Worker(string fio,string fac,DateTime date1,DateTime date2):base(fio,fac)
        {
            Date1 = date1;
            Date2 = date2;
        }
        public override void Print()
        {
            Console.WriteLine($"ФИО:{FIO},Факультет:{Fac},Дата начала работ:{Date1},Дата конца работ:{Date2}");
        }
        public override void RegN()
        {
            if(Date2<DateTime.Now)
            {
                Console.WriteLine($"Пропуск для работника {FIO} аннулирован");
            }
        }
        public override void RegY()
        {
            if (Date2 > DateTime.Now)
            {
                Console.WriteLine($"Пропуск для работника {FIO} обновлен");
            }
        }
    }
}
