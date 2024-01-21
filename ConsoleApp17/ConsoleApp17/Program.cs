using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите количество учащихся:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //School[] mass = new School[n];
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    Console.Write("ФИО=");
            //    string fio = Console.ReadLine();
            //    Console.Write("пол=");
            //    string pol = Console.ReadLine();
            //    Console.Write("Год рождения=");
            //    int year = Convert.ToInt32(Console.ReadLine());
            //    mass[i] = new School(fio, pol, year);
            //}
            //foreach (var elem in mass)
            //{
            //    elem.ShowInfo();
            //}
            //Console.WriteLine($"Количество мальчиков:{School.men}\tКоличество девочек:{School.women}");

            Console.Write("Количество спортсменов:");
            int n = Convert.ToInt32(Console.ReadLine());
            Sport[] mass = new Sport[n];
            for(int i=0;i<mass.Length;i++)
            {
                Console.Write("Введите ФИО:");
                string fio = Console.ReadLine();
                Console.Write("Введите рост:");
                int height = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите вес:");
                int weight = Convert.ToInt32(Console.ReadLine());
                mass[i] = new Sport(fio,height,weight);
            }
            foreach(var elem in mass)
            {
                if(elem.Weight>=70)
                {
                    elem.ShowInfo();
                }
            }
            Console.WriteLine($"Количество спортсменов с весом более 70:{Sport.weight70}");
            Console.ReadKey();
        }
    }
}
