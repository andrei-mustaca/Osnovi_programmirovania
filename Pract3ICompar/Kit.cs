using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3ICompar
{
    internal class Kit:Goods
    {
        private List<string> list;
        public List<string> List { set; get; }
        private DateTime date1;
        public DateTime Date1 { set; get; }
        private int date2;
        public int Date2 { set; get; }
        public Kit(string name, int price, List<string> list, DateTime date1, int date2) : base(name, price)
        {
            List = list;
            Date1 = date1;
            Date2 = date2;
        }
        public override void Print()
        {
            Console.WriteLine($"Название:{Name}");
            Console.WriteLine($"Цена:{Price}");
            Console.WriteLine("Продукты:");
            foreach (var elem in List)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine($"Дата производства:{Date1.ToShortDateString()}");
            Console.WriteLine($"Срок годности:{Date2} дней");
        }
        public override void Deadline()
        {
            if (DateTime.Now > Date1.AddDays(Date2))
            {
                Console.WriteLine(Name);
            }
        }
        public static Kit Enter()
        {
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введите цену:");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество продуктов:");
            int count = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>(count);
            for (int i = 0; i < count; i++)
            {
                Console.Write("Введите название:");
                string name_goods = Console.ReadLine();
                list.Add(name_goods);
            }
            Console.Write("Введите дату производства:");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите срок годности:");
            int date2 = Convert.ToInt32(Console.ReadLine());
            return new Kit(name, price, list, date1, date2);
        }
    }
}
