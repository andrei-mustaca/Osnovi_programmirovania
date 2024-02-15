using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввести размерность коллекции:");
            int a = Convert.ToInt32(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            bool flag = true;
            int sumE = 0;
            int sumI = 0;
            int sumM = 0;
            while (flag)
            {
                Console.Write("Ввести идентификатор:");
                string b = Console.ReadLine();
                switch (b)
                {
                    case "e":
                        list.Add(Employee.Enter());
                        break;
                    case "i":
                        list.Add(Injiner.Enter());
                        break;
                    case "m":
                        list.Add(Manager.Enter());
                        break;
                    default :Console.WriteLine("Нет такого статуса");
                             flag =false ;
                        break;
                }
            }
            foreach(var elem in list)
            {
                elem.Print();
                Console.WriteLine($"Доход:{elem.Cost()}");
            }

            Console.ReadKey();
        }
    }
}
