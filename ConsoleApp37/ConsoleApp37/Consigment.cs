using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Consigment:Product
    {
        private int kol_vo;
        public int Kol_vo
        {
            set { kol_vo = value; }
            get { return kol_vo; }
        }
        private DateTime date1;
        public DateTime Date1
        {
            set { date1 = value; }
            get { return date1; }
        }
        private int expiration1;
        public int Expiration1
        {
            set { expiration1 = value; }
            get { return expiration1; }
        }
        public Consigment(string name,int cost,int kol_vo,DateTime date1,int expiration1):base(name,cost)
        {
            Kol_vo = kol_vo;
            Date1 = date1;
            Expiration1 = expiration1;
        }
        public override void Print()
        {
            Console.WriteLine($"Название:{Name}\nЦена:{Cost}\nКол-во:{Kol_vo}\nДата производства:{Date1}\nСрок годности:{Expiration1}");
        }
        public override bool ExpirationDate()
        {
            if (DateTime.Now > Date1.AddMonths(Expiration1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Consigment Enter()
        {
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введите стоимость:");
            int cost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во продуктов:");
            int kol_vo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите срок годности:");
            int expiration = Convert.ToInt32(Console.ReadLine());
            return new Consigment(name,cost,kol_vo,date,expiration);
        }
    }
}
