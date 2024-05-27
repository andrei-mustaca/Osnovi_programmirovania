using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перечисления
{
    class Calc
    {
        public enum Calcs
        {
            Add,
            Sub,
            Mul,
            Div
        }
        public static double Rez(double x,double y)
        {
            Console.WriteLine("[0] Сложение");
            Console.WriteLine("[1] Вычитание");
            Console.WriteLine("[2] Умножение");
            Console.WriteLine("[3] Деление");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case (int)Calcs.Add:return x + y;
                case (int)Calcs.Sub:return x - y;
                case (int)Calcs.Mul:return x * y;
                case (int)Calcs.Div:
                    if(y==0)
                    {
                        return 0;
                    }
                    else
                    {
                        return x / y;
                    }
                default:return 0;
            }
        }
    }
}
