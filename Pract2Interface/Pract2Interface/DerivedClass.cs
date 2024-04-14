using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2Interface
{
    class DerivedClass:IInterface
    {
        public void Method()
        {
            Console.WriteLine("Метод,реализованный в DerivedClass");
        }
    }
}
