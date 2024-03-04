using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Produce:Product
    {
        private DateTime date;
        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }
        private int expiration;
        public int Expiration
        {
            set { expiration = value; }
            get { return expiration; }
        }
        public Produce(string name,int cost,DateTime date,int expiration):base(name,cost)
        {
            Date = date;
            Expiration = expiration;
        }
        public override void Print()
        {
            Console.WriteLine($"Название:{Name}\nЦена:{Cost}\nДата производства:{Date}\nСрок годности:{Expiration}");
        }
        public override bool ExpirationDate()
        {
            if(DateTime.Now>Date.AddMonths(Expiration))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Produce Enter()
        {
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введите стоимость:");
            int cost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите срок годности:");
            int expiration = Convert.ToInt32(Console.ReadLine());
            return new Produce(name,cost,date,expiration);
        }
    }
}
