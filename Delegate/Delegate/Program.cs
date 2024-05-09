using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    class Program
    {
        public delegate void Message();
        public delegate int Message2(int x, int y);
        public delegate double Message3(int M,int N);
        public delegate int Message4(int m, int n);
        static void Main(string[] args)
        {
            //Задача 1
            //Message mes;
            //mes = Morning;
            //mes();
            //mes = Evening;
            //mes();

            //Задача 2
            //Console.Write("Введите x:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите y:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Message2 mes;
            //bool flag = true;
            //while(flag)
            //{
            //    Console.WriteLine("[1] Сложение");
            //    Console.WriteLine("[2] Вычитание");
            //    Console.WriteLine("[3] Умножение");
            //    Console.WriteLine("[4] Деление");
            //    Console.WriteLine("[5] Выход");
            //    switch(Console.ReadKey(true).KeyChar)
            //    {
            //        case '1':
            //            mes = Add;
            //            Console.WriteLine($"Результат:{mes(x,y)}");
            //            break;
            //        case '2':
            //            mes = Sub;
            //            Console.WriteLine($"Результат:{mes(x,y)}");
            //            break;
            //        case '3':
            //            mes = Mul;
            //            Console.WriteLine($"Результат:{mes(x,y)}");
            //            break;
            //        case '4':
            //            mes = Div;
            //            Console.WriteLine($"Результат:{mes(x,y)}");
            //            break;
            //        case '5':return;
            //        default:Console.WriteLine("Ошибка, попробуйте еще раз");
            //            break;
            //    }
            //}

            //Задача 3
            //Message3 mes;
            //for(int i=0;i<3;i++)
            //{
            //    Console.Write("Введите начало диапазона:");
            //    int m = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Введите конец диапазона:");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    mes = Average;
            //    Console.WriteLine($"Среднее арифметическое:{mes(m,n)}");
            //}

            //Задача 4
            //Message4 mes;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Введите начало диапазона:");
            //    int m = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Введите конец диапазона:");
            //    int n = Convert.ToInt32(Console.ReadLine());
            //    mes = Sum;
            //    Console.WriteLine($"Сумма:{mes(m, n)}");
            //}
            Console.ReadKey();
        }
        public static void Morning()
        {
            Console.WriteLine("Доброе утро!");
        }
        public static void Evening()
        {
            Console.WriteLine("Добрый вечер!");
        }
        public static int Add(int x,int y)
        {
            return x + y;
        }
        public static int Sub(int x,int y)
        {
            return x - y;
        }
        public static int Mul(int x,int y)
        {
            return x * y;
        }
        public static int Div(int x,int y)
        {
            if(y!=0)
            {
                return x / y;
            }
            else
            {
                return 0;
            }
        }
        public static double Average(int m,int n)
        {
            int count = 0;
            int sum = 0;
            for(int i=m;i<=n;i++)
            {
                sum = sum + i;
                count++;
            }
            return sum / count;
        }
        public static int Sum(int m,int n)
        {
            int sum = 0;
            for(int i=m; i<=n;i++)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
