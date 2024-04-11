using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum1Interface
{
    class Krug:Interface1
    {
        const double PI = 3.14;
        public string Name { set; get; }
        public int R { set; get; }
        public int D { set; get; }
        public Krug(string name,int r,int d)
        {
            Name = name;
            R = r;
            D = d;
        }
        void Interface1.Print()
        {
            Console.WriteLine($"Название:{Name},Радиус:{R},Диаметр:{D}");
        }
        double Interface1.P()
        {
            return PI * D;
        }
        double Interface1.S()
        {
            return PI * Math.Pow(R,2);
        }
        public static Krug Enter()
        {
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введите радиус:");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите диаметр:");
            int d = Convert.ToInt32(Console.ReadLine());
            return new Krug(name,r,d);
        }
    }
}
