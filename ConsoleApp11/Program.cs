using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Point.X();
            int y = Point.Y();
            Point point1 = new Point(x,y);
            point1.Input();
            Console.WriteLine($"Длина от начала координат={point1.Dlina():f2}");

            //Address address = new Address(2,"Россия","Москва","Гагарина","15","7");
            //address.GetInfo();
            Console.ReadKey();
        }
    }
}
