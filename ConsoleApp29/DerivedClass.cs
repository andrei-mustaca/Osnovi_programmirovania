using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    /// <summary>
    /// Наследуемый от класса CClass
    /// </summary>
    internal class DerivedClass:CClass
    {
        /// <summary>
        /// метод из класса AClass
        /// </summary>
        public override void Method1()
        {
            Console.WriteLine("Метод Method1");
        }
        /// <summary>
        /// Метод из класса BClass
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public override int Method2(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Метод из класса CClass
        /// </summary>
        /// <param name="hello"></param>
        /// <returns></returns>
        public override string Method3(string hello)
        {
            return hello;
        }
        public void Print()
        {
            Console.WriteLine("Обычный метод");
        }
    }
}
