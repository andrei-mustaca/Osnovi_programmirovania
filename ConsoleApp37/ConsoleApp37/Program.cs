using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            bool flag = true;
            while (flag)
            {
                Console.Write("Введите название:");
                string name = Console.ReadLine();
                switch (name)
                {
                    case "Продукт":list.Add(Produce.Enter());
                        break;
                    case "Партия":list.Add(Consigment.Enter());
                        break;
                    case "Комплект":list.Add(Set.Enter());
                        break;
                    case "Конец ":flag = false;
                        break;
                    default:Console.WriteLine("Введено неправильное слово:");
                        break;
                }
            }
            Console.WriteLine();
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].ExpirationDate()==false)
                {
                    list[i].Print();
                }
            }
            Console.ReadKey();
        }
    }
}
