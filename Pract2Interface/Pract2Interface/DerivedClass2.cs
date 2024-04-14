using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2Interface
{
    class DerivedClass2:IInterface2
    {
        public double PI()
        {
            return Math.PI;
        }
        public int Ret()
        {
            return 10;
        }
        public double Pow()
        {
            Console.Write("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());
            return Math.Pow(x,2);
        }
        public double Sqrt()
        {
            Console.Write("Введите x:");
            int x = Convert.ToInt32(Console.ReadLine());
            return Math.Sqrt(x);
        }
    }
}
