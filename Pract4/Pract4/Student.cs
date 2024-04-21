using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class Student:Main
    {
        public int Year { set; get; }
        public Student(string fio,string fac,int year):base(fio,fac)
        {
            Year = year;
        }
        public override void Print()
        {
            Console.WriteLine($"ФИО:{FIO},Факультет:{Fac},Год поступления:{Year}");
        }
        public override void RegN()
        {
            if(Year+4<=DateTime.Now.Year)
            {
                Console.WriteLine($"Пропуск для студента {FIO} аннулирован");
            }
        }
        public override void RegY()
        {
            if(Year+4>DateTime.Now.Year)
            {
                Console.WriteLine($"Пропуск для студента {FIO} обновлен");
            }
        }
    }
}
