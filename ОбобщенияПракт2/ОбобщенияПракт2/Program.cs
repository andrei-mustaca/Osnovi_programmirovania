using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОбобщенияПракт2
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle<int> tr1 = new Triangle<int>(10,11,23,22,13,15);
            tr1.Print();
            Console.WriteLine($"Площадь:{tr1.S():f2}");
            Triangle<uint> tr2 = new Triangle<uint>(3,6,5,4,7,9);
            tr2.Print();
            Console.WriteLine($"Площадь:{tr2.S()}");
            Triangle<double> tr3 = new Triangle<double>(20.5,23.6,21.4,32.3,21.7,22.2);
            tr3.Print();
            Console.WriteLine($"Площадь:{tr3.S():f2}");

            Segment<int> s1 = new Segment<int>(10,12,20,21);
            s1.Print();
            Console.WriteLine($"Длина:{s1.L():f2}");
            Segment<long> s2 = new Segment<long>(100,111,125,130);
            s2.Print();
            Console.WriteLine($"Длина:{s2.L():f2}");
            Segment<double> s3 = new Segment<double>(12.5,11.2,16.4,17.5);
            s3.Print();
            Console.WriteLine($"Длина:{s3.L():f2}");
            Console.ReadKey();
        }
    }
}
