using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //Point<int> p1 = new Point<int>(10,10);
            //p1.Print();
            //Point<uint> p2 = new Point<uint>(12u,13u);
            //p2.Print();
            //Point<double> p3 = new Point<double>(10.1,13.13);
            //p3.Print();

            //2
            //Triangle<int> tr1 = new Triangle<int>(1,2,3);
            //tr1.Print();
            //Console.WriteLine($"Площадь={tr1.Area()}");
            //Triangle<uint> tr2 = new Triangle<uint>(2u, 3u, 4u);
            //tr2.Print();
            //Console.WriteLine($"Площадь={tr2.Area()}");
            //Triangle<double> tr3 = new Triangle<double>(2.5, 3.5, 4.5);
            //tr3.Print();
            //Console.WriteLine($"Площадь={tr3.Area()}");

            //3
            Segment<int> s1 = new Segment<int>(10,20,10,20);
            s1.Print();
            Console.WriteLine($"Длина={s1.L()}");
            Segment<long> s2 = new Segment<long>(10L, 20L, 10L, 20L);
            s2.Print();
            Console.WriteLine($"Длина={s2.L()}");
            Segment<double> s3 = new Segment<double>(10.5, 15.5, 10.5, 15.5);
            s3.Print();
            Console.WriteLine($"Длина={s3.L()}");
            Console.ReadKey();
        }
    }
}
