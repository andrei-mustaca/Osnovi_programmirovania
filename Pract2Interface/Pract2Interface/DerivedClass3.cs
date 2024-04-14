using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2Interface
{
    class DerivedClass3:IInterface1_3
    {
        void IInterface1_1.Method1()
        {
            Console.WriteLine("Метод Method1");
        }
        void IInterface1_2.Method2()
        {
            Console.WriteLine("Метод Method2");
        }
        void IInterface1_3.Method3()
        {
            Console.WriteLine("Метод Method3");
        }
    }
}
