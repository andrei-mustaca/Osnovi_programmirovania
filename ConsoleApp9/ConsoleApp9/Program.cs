using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Console.Write("Введите а=");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите b=");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Compar(ref a, ref b);
            //Console.WriteLine($"a={a}\t b={b}");

            //Задача 2
            //Ascending_order();

            //Задача 3
            //Console.Write("Ввести длину окружности:");
            //double dlina = Convert.ToDouble(Console.ReadLine());
            //Krug(ref dlina);

            //Задача 4
            //Console.WriteLine("Введите предложение:");
            //string stroka = Console.ReadLine();
            //int count = Count(stroka);
            //Console.WriteLine($"Количество букв н в предложении={count}");
            Console.ReadKey();
        }

        //Задача 1
        /// <summary>
        /// Дополнительный метод выполняющий обмен значений между переменной a и переменной b,с помощью третьей переменной c
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        //public static void Compar(ref int a,ref int b)
        //{
        //    int c = a;
        //    a = b;
        //    b = c;
        //}

        //Задача 2
        ///<summary>
        ///Дополнительный метод вводящий три числа и сортирующий их в порядке возрастания
        /// </summary>
        //public static void Ascending_order()
        //{
        //    int[] mass = new int[3];
        //    for (int i = 0; i < mass.Length; i++)
        //    {
        //        Console.Write($"mass[{i}]=");
        //        mass[i] = Convert.ToInt32(Console.ReadLine());
        //    }
        //    Array.Sort(mass);
        //    foreach (int number in mass)
        //    {
        //        Console.WriteLine(number);
        //    }
        //}

        //Задача 3
        ///Метод вычисляющий длину окружности и площадь круга и выводящий их
        //public static void Krug(ref double dlina)
        //{
        //    double L = 2 * Math.PI * dlina;
        //    double S = Math.PI * Math.Pow(dlina, 2);
        //    Console.WriteLine($"dlina={dlina}\t L={L:f2}\t S={S:f2}");
        //}

        //Задача 4
        //public static int Count(string stroka)
        //{
        //    int count = 0;
        //    for(int i=0;i<stroka.Length;i++)
        //    {
        //        if(stroka[i]=='н')
        //        {
        //            count++;
        //        }
        //    }
        //    return count;
        //}
    }
}
