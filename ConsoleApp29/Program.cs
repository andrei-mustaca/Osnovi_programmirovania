using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass der1 = new DerivedClass();
            der1.Method1();
            Console.WriteLine();
            Console.WriteLine(der1.Method2(2, 3));
            Console.WriteLine();
            Console.WriteLine(der1.Method3("Привет Антон"));
            Console.WriteLine();
            der1.Print();
            Console.ReadKey();
        }
    }
}
