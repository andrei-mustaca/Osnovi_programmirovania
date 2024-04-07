using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract5
{
    class Party:Goods
    {
        private int count;
        public int Count { set; get; }
        private DateTime date1;
        public DateTime Date1 { set; get; }
        private int date2;
        public int Date2 { set; get; }
        public Party(string name,int price,int count,DateTime date1,int date2):base(name,price)
        {
            Count = count;
            Date1 = date1;
            Date2 = date2;
        }
        public override void Print()
        {
            Console.WriteLine($"Название:{Name}");
            Console.WriteLine($"Цена:{Price}");
            Console.WriteLine($"Количество:{Count}");
            Console.WriteLine($"Дата производства:{Date1.ToShortDateString()}");
            Console.WriteLine($"Срок годности:{Date2} дней");
        }
        public override void Deadline()
        {
            if(DateTime.Now>Date1.AddDays(Date2))
            {
                Console.WriteLine(Name);
            }
        }
        public static Party Enter()
        {
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введите цену:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество:");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату производства:");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите срок годности:");
            int date2 = Convert.ToInt32(Console.ReadLine());
            return new Party(name, price,count, date1, date2);
        }
    }
}
