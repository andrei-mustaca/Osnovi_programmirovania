using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    class FreeUsl:Software
    {
        public DateTime Date1 { set; get; }
        public int Date2 { set; get; }
        public FreeUsl(string manufacturer,string name,DateTime date1,int date2):base(manufacturer,name)
        {
            Date1 = date1;
            Date2 = date2;
        }
        public override void Print()
        {
            Console.WriteLine($"Название:{Name}");
            Console.WriteLine($"Производитель:{Manufacturer}");
            Console.WriteLine($"Дата установки:{Date1}");
            Console.WriteLine($"Срок использования:{Date2}");
        }
        public override void Usable()
        {
            if(DateTime.Now<Date1.AddDays(Date2))
            {
                Console.WriteLine(Name);
            }
        }
        public static FreeUsl Enter()
        {
            Console.Write("Введите производителя:");
            string manufacturer = Console.ReadLine();
            Console.Write("Введите имя:");
            string name = Console.ReadLine();
            Console.Write("Введите дату установки:");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите срок использования:");
            int date2 = Convert.ToInt32(Console.ReadLine());
            return new FreeUsl(manufacturer, name,date1,date2);
        }
    }
}
