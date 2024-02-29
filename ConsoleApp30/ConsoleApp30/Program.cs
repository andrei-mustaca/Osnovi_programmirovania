using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Russian("Иван");
            Person p2 = new Moldovan("Ионел");
            Person p3 = new Englishmen("James");
            p1.Hello();
            p2.Hello();
            p3.Hello();
            Console.ReadKey();
        }
    }
}
