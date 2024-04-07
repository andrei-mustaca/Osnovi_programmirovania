using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Goods> list = new List<Goods>();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("[1] Добавить продукт");
                Console.WriteLine("[2] Добавить комплект");
                Console.WriteLine("[3] Добавить партию");
                Console.WriteLine("[4] Вывод");
                Console.WriteLine("[5] Поиск просроченного товара");
                Console.WriteLine("[6] Выход");
                switch(Console.ReadKey(true).KeyChar)
                {
                    case '1':list.Add(Product.Enter());
                        break;
                    case '2':list.Add(Kit.Enter());
                        break;
                    case '3':list.Add(Party.Enter());
                        break;
                    case '4':
                        foreach(var elem in list)
                        {
                            elem.Print();
                            Console.WriteLine();
                        }
                        break;
                    case '5':
                        Console.WriteLine("Просроченные товары:");
                        foreach(var elem in list)
                        {
                            elem.Deadline();
                        }
                        break;
                    case '6':return;
                    default:Console.WriteLine("Ошибка,попробуйте еще раз");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
