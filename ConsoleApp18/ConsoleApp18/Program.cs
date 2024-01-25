using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dateTime = new DateTime();
            ////Способы вывода
            //Console.WriteLine(dateTime);//01.01.0001 0:00:00
            ////Метод ToString() System.Object возвращает символьную строку,содержащую описание того объекта, для которого он вызывается
            //Console.WriteLine(dateTime.ToString());//01.01.0001 0:00:00
            ////MinValue – наименьшее значение типа DateTime
            //Console.WriteLine($"Наименьшее значение типа DateTime - {DateTime.MinValue}");//01.01.0001
            ////MaxValue – наибольшее значение типа DateTime
            //Console.WriteLine($"Наибольшее значение типа DateTime-{ DateTime.MaxValue}");//31.12.9999
            //DateTime dateTime1 = new DateTime(1965, 12, 30);
            //Console.WriteLine(dateTime1.ToString());//30.12.1965 0:00:00
            //DateTime dateTime2 = new DateTime(30, 12, 1965);
            //Console.WriteLine(dateTime2.ToString());//ошибка!
            //DateTime dateTime3 = new DateTime(1965, 13, 30);
            //Console.WriteLine(dateTime3.ToString());//ошибка!
            //DateTime dateTime4 = new DateTime(1989, 01, 27, 8, 30, 45); //27.01.1989 8:30:45
            //Console.WriteLine(dateTime4.ToString());

            //DateTime today = DateTime.Now;
            //Console.WriteLine($"Текущая дата и время: {today}");//19.01.2024 10:40:36
            //Console.WriteLine($"Год:{today.Year}");//Год: 2024
            //Console.WriteLine($"Месяц: {today.Month}");//Месяц: 1
            //Console.WriteLine($"День: {today.Day}");//День: 19
            //Console.WriteLine($"День недели: {today.DayOfWeek}");//День недели: Friday
            //Console.WriteLine($"День года: {today.DayOfYear}");//День недели: Friday

            //DateTime myValue1 = DateTime.Now;
            //Console.WriteLine(myValue1.ToString());
            //Console.WriteLine(myValue1.AddDays(3).ToLongDateString());
            //Console.WriteLine(myValue1.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue1.AddDays(-3).ToLongDateString());
            //DateTime date1 = new DateTime(2015, 7, 20, 18, 30, 25); // 20.07.2015 18:30:25
            //DateTime date2 = new DateTime(2015, 7, 20, 15, 30, 25); // 20.07.2015 15:30:25
            //Console.WriteLine(date1.Subtract(date2)); // 03:00:00

            //DateTime now = DateTime.Now;
            //Console.WriteLine($"D: {now.ToString("D")}");//полный формат даты
            //Console.WriteLine($"d: {now.ToString("d")}");//краткий формат даты
            //Console.WriteLine($"F: {now.ToString("F")}");//полный формат даты и времени
            //Console.WriteLine($"f: {now.ToString("f")}");//полный формат даты и краткий формат времени
            //Console.WriteLine($"G: {now.ToString("G")}");//краткий формат даты и полный формат времени
            //Console.WriteLine($"g: {now.ToString("g")}");//краткий формат даты и времени
            //Console.WriteLine($"M: {now:M}");//формат дней месяца
            //Console.WriteLine($"O: {now:O}");//формат обратного преобразования даты и времени
            //Console.WriteLine($"o: {now:o}");//формат обратного преобразования даты и времени
            //Console.WriteLine($"R: {now:R}");//время по Гринвичу
            //Console.WriteLine($"s: {now:s}");//сортируемый формат даты и времени
            //Console.WriteLine($"T: {now:T}");//полный формат времени
            //Console.WriteLine($"t: {now:t}");//краткий формат времени
            //Console.WriteLine($"U: {now:U}");//полный универсальный полный формат даты и времени
            //Console.WriteLine($"u: {now:u}");//краткий универсальный полный формат даты и времени
            //Console.WriteLine($"Y: {now:Y}");//формат года

            //Задание 1
            //DateTime date = new DateTime(2022,01,20,13,05,20);
            //Console.WriteLine($"Date:{date.ToString("d")}");
            //Console.WriteLine($"Date:{date.ToString("D")}");
            //Console.WriteLine($"Date:{date.DayOfWeek},{date.ToString("D")}");

            //Console.WriteLine($"Date:{date:T}");
            //Console.WriteLine($"Date:{date:t}");

            //Console.WriteLine($"Date:{date.ToString("G")}");
            //Console.WriteLine($"Date:{date.ToString("D")} {date.ToString("t")}");
            //Console.WriteLine($"Date:{date.ToString("D")} {date.ToString("T")}");
            //Console.WriteLine($"Date:{date.ToString("R")}");
            //Console.WriteLine($"Date:{date.ToString("s")}");

            //Задание 2
            //Console.WriteLine("Сколько вам лет:");
            //int year = Convert.ToInt32(Console.ReadLine());
            //DateTime now = DateTime.Now;
            //Console.WriteLine($"Ты родился в {now.AddYears(-year)} году");

            //Задание 3
            //Console.WriteLine("Какого вы года рождения:");
            //int year = Convert.ToInt32(Console.ReadLine());
            //DateTime year1 = new DateTime(2006,12,04);
            //DateTime now = new DateTime(2023,01,25);
            //Console.WriteLine($"Вам {year1.Subtract(now)} лет");
            Console.ReadKey();
        }
    }
}
