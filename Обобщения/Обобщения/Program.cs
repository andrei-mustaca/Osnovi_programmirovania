using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Обобщения
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Введите x:");
            //int x = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Введите y:");
            //int y = Convert.ToInt32(Console.ReadLine());
            //Point<int> p1 = new Point<int>(x,y);
            //p1.Print();

            //Console.Write("Введите x:");
            //double x1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите y:");
            //double y2 = Convert.ToDouble(Console.ReadLine());
            //Point<double> p2 = new Point<double>(x1, y2);
            //p2.Print();

            //Console.Write("Введите x:");
            //string x2 = Console.ReadLine();
            //Console.Write("Введите y:");
            //string y3 = Console.ReadLine();
            //Point<string> p3 = new Point<string>(x2, y3);
            //p3.Print();

            Calc<int, int> c1 = new Calc<int, int>();
            c1.Calculator(10,14);
            Calc<double, int> c2 = new Calc<double, int>();
            c2.Calculator(10.4,-11);
            Calc<double, double> c3 = new Calc<double, double>();
            c3.Calculator(11.5,9.7);
            Calc<int, string> c4 = new Calc<int, string>();
            c4.Calculator(10,"9");
            Console.ReadKey();
        }
    }
}
