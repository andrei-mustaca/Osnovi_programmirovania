using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структуры
{
    struct Book
    {
        public string name;
        public string fio;
        public DateTime date;
        public int kol_vo;
        public Book(string name,string fio,DateTime date,int kol_vo)
        {
            this.name = name;
            this.fio = fio;
            this.date = date;
            this.kol_vo = kol_vo;
        }
        public void Print()
        {
            Console.WriteLine($"Название:{name}\nФИО автора:{fio}\nДата издания:{date.ToShortDateString()}\nКол-во страниц:{kol_vo}");
        }
        public static Book Enter()
        {
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введите фио автора:");
            string fio = Console.ReadLine();
            Console.Write("Введите дату:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите количество страниц:");
            int kol_vo = Convert.ToInt32(Console.ReadLine());
            return new Book(name,fio,date,kol_vo);
        }
    }
}
