using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Console.Write("Ввести первую дату:");
            //DateTime date1 = DateTime.Parse(Console.ReadLine());
            //Console.Write("Ввести вторую дату:");
            //DateTime date2 = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine($"Разница между датами в днях:{(date1-date2).Days}");

            //Задача 2
            //Console.Write("Ввести первую дату:");
            //DateTime date1 = DateTime.Parse(Console.ReadLine());
            //Console.Write("Ввести вторую дату:");
            //DateTime date2 = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine($"До конца месяца осталось:{(date1 - date2).Days}");

            //Задача 3
            //a
            //Console.Write("Дата рождения:");
            //DateTime date = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine($"День недели:{date.DayOfWeek}");

            //b
            //Console.Write("Дата рождения:");
            //DateTime date = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine($"День года:{date.DayOfYear}");

            //c
            //Console.Write("Дата рождения:");
            //DateTime date = DateTime.Parse(Console.ReadLine());
            //bool year = DateTime.IsLeapYear(date.Year);
            //if(year==true)
            //{
            //    Console.WriteLine("Год високосный");
            //}
            //else
            //{
            //    Console.WriteLine("Год не високосный");
            //}

            //d
            //Console.Write("Дата рождения:");
            //DateTime date = DateTime.Parse(Console.ReadLine());
            //DateTime nextdate = date.AddYears(DateTime.Now.Year-date.Year);
            //if(nextdate<DateTime.Now)
            //{
            //    nextdate = nextdate.AddYears(1);
            //}
            //Console.WriteLine($"Ближайший день рождения:{nextdate:dddd, dd MMMM yyyy}");

            //e
            //Console.Write("Дата рождения:");
            //DateTime date = DateTime.Parse(Console.ReadLine());
            //int age = DateTime.Now.Year - date.Year;
            //if(DateTime.Now<date.AddYears(age))
            //{
            //    age--;
            //}
            //Console.WriteLine($"Мне {age} полных лет");

            //f
            //Console.Write("Дата рождения:");
            //DateTime date = DateTime.Parse(Console.ReadLine());
            //DateTime nextdate = date.AddYears(DateTime.Now.Year-date.Year);
            //TimeSpan interval = nextdate - DateTime.Now;
            //Console.WriteLine($"Дней до ближайшего дня рождения:{interval.Days}");
            Console.ReadKey();
        }
    }
}
