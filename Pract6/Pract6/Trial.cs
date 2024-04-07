using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    class Trial:Software
    {
        public int Price { set; get; }
        public DateTime Date1 { set; get; }
        public int Date2 { set; get; }
        public Trial(string manufacturer,string name,int price,DateTime date1,int date2):base(manufacturer,name)
        {
            Price = price;
            Date1 = date1;
            Date2 = date2;
        }
        public override void Print()
        {
            Console.WriteLine($"Название:{Name}");
            Console.WriteLine($"Производитель:{Manufacturer}");
            Console.WriteLine($"Цена:{Price}");
            Console.WriteLine($"Дата установки:{Date1}");
            Console.WriteLine($"Срок использования:{Date2}");
        }
        public override void Usable()
        {
            if (DateTime.Now < Date1.AddDays(Date2))
            {
                Console.WriteLine(Name);
            }
        }
        public static Trial Enter()
        {
            Console.Write("Введите производителя:");
            string manufacturer = Console.ReadLine();
            Console.Write("Введите имя:");
            string name = Console.ReadLine();
            Console.Write("Введите цену:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату установки:");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите срок использования:");
            int date2 = Convert.ToInt32(Console.ReadLine());
            return new Trial(manufacturer, name,price, date1, date2);
        }
    }
}
