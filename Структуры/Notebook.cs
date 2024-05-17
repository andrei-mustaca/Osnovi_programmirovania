using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структуры
{
    struct Notebook
    {
        public string model;
        public string proizvod;
        public int price;
        public Notebook(string model,string proizvod,int price)
        {
            this.model = model;
            this.proizvod = proizvod;
            this.price = price;
        }
        public void Print()
        {
            Console.WriteLine($"Модель:{model}\nПроизводитель:{proizvod}\nЦена:{price}");
        }
        public static Notebook Enter()
        {
            Console.Write("Введите модель:");
            string model = Console.ReadLine();
            Console.Write("Введите производителя:");
            string proizvod=Console.ReadLine();
            Console.Write("Введите цену:");
            int price = Convert.ToInt32(Console.ReadLine());
            return new Notebook(model,proizvod,price);
        }
    }
}
