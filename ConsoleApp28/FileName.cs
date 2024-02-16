using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DerivedClass:AClass
    {
        /// <summary>
        /// Переопределение виртуального иетода
        /// </summary>
        public override void Method2()
        {
            base.Method2();
            Console.WriteLine("Виртуальный метод Method2 из класса DerivedClass");
        }
        /// <summary>
        /// Абстрактный метод наследуемый из класса AClass
        /// </summary>
        public override void Method3()
        {
            Console.WriteLine("Метод Method3 из класса AClass реализованный в классе DerivedClass");
        }
        public override void Method4()
        {
            Console.WriteLine("Метод Method4 из класса AClass реализованный в классе DerivedClass");
        }
    }
}
