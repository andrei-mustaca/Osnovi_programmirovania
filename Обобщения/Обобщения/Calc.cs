using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обобщения
{
    class Calc<A,B>
    {
        public void Calculator(A x,B y)
        {
            dynamic vx = x;
            dynamic vy = y;
            Console.WriteLine("[1] Сложение");
            Console.WriteLine("[2] Вычитание");
            Console.WriteLine("[3] Умножение");
            Console.WriteLine("[4] Деление");
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': Console.WriteLine($"{x}+{y}={vx + vy}");
                    break;
                case '2': Console.WriteLine($"{x}-{y}={vx - vy}");
                    break;
                case '3': Console.WriteLine($"{x}*{y}={vx * vy}");
                    break;
                case '4': Console.WriteLine($"{x}/{y}={vx / vy}");
                    break;
            }
            
        }
    }
}
