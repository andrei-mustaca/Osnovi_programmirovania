using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum1Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Interface1> list = new List<Interface1>();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("[1] Добавить квадрат");
                Console.WriteLine("[2] Добавить прямоугольник");
                Console.WriteLine("[3] Добавить круг");
                Console.WriteLine("[4] Выход");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':list.Add(Kvadrat.Enter());
                        break;
                    case '2':list.Add(Pramougolnic.Enter());
                        break;
                    case '3':list.Add(Krug.Enter());
                        break;
                    case '4':flag = false;
                        break;
                    default:Console.WriteLine("Ошибка,попробуйте еще раз");
                        break;
                }
            }
            bool flag1 = true;
            while(flag1)
            {
                Console.WriteLine("[1] Вывод информации");
                Console.WriteLine("[2] Выход");
                switch(Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        foreach(var elem in list)
                        {
                            elem.Print();
                            Console.WriteLine($"Площадь:{elem.P()},Периметр(длинна):{elem.S()}");
                        }
                        break;
                    case '2':flag1 = false;
                        break;
                    default:Console.WriteLine("Ошибка,повторите еще раз");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
