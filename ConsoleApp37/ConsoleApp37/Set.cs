using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Set:Produce
    {
        public List<string>Listname
        {
            set;
            get;
        }
        public Set(string name,int cost, DateTime date,int expiration,List<string>list):base(name,cost,date,expiration)
        {
            List<string> List = list;
        }
        public override void Print()
        {
            Console.WriteLine($"Название:{Name}\nЦена:{Cost}\nДата производства:{Date}\nСрок годности:{Expiration}");
        }
        public override bool ExpirationDate()
        {
            if (DateTime.Now > Date.AddMonths(Expiration))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Set Enter()
        {
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введите стоимость:");
            int cost = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите дату:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите срок годности:");
            int expiration = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите размерность колекции:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>(n);
            for(int i=0;i<n;i++)
            {
                Console.Write("Введите наименование продукта:");
                string product = Console.ReadLine();
                list.Add(product);
            }
            return new Set(name,cost,date,expiration,list);
        }
    }
}
