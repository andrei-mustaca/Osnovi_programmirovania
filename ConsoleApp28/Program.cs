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
            DerivedClass der1= new DerivedClass();
            der1.Method1();
            der1.Method2();
            der1.Method3();
            der1.Method4();
            Console.WriteLine("");
            Console.WriteLine("");
            AClass aClass = new DerivedClass();
            aClass.Method1();
            aClass.Method2();
            aClass.Method3();
            aClass.Method4();
            Console.ReadKey();
        }
    }
}
