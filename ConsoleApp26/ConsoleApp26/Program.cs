using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Console.Write("Введите кол-во элементов:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //List <Employee> list= new List<Employee>(a);
            //bool flag = true;
            //while(flag)
            //{
            //    Console.Write("Статус:");
            //    string b = Console.ReadLine();
            //    if(b=="e")
            //    {
            //        list.Add(Employee.Enter());
            //    }
            //    else if(b=="i")
            //    {
            //        list.Add(Injineer.Enter());
            //    }
            //    else
            //    {
            //        flag = false;
            //    }
            //}
            //foreach(var elem in list)
            //{
            //    elem.Print();
            //    Console.WriteLine($"Доход:{elem.Cost()}");
            //}

            //Задача 2
            Console.Write("Введите кол-во элементов:");
            int a = Convert.ToInt32(Console.ReadLine());
            List<Avtobus> list = new List<Avtobus>(a);
            bool flag = true;
            while (flag)
            {
                Console.Write("Статус:");
                string b = Console.ReadLine();
                if (b == "a")
                {
                    list.Add(Avtobus.Enter());
                }
                else if (b == "t")
                {
                    list.Add(TuristA.Enter());
                }
                else
                {
                    flag = false;
                }
            }
            foreach (var elem in list)
            {
                elem.Print();
                Console.WriteLine($"Доход:{elem.Cost()}");
            }
            Console.ReadLine();
        }
    }
}
