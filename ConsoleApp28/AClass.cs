using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Абстрактный класс
    /// </summary>
    abstract class AClass
    {
        /// <summary>
        /// Обычный метод
        /// </summary>
        public void Method1()
        {
            Console.WriteLine("Обычный Method1 из абстрактного класса AClass");
        }
       /// <summary>
       /// Виртуальный метод
       /// </summary>
        public virtual void Method2()
        {
            Console.WriteLine("Виртуальный метод Method2 из абстрактного класса AClass");
        }
        /// <summary>
        /// Абстрактный метод абстрактного класса
        /// </summary>
        public abstract void Method3();
        /// <summary>
        /// Абстрактный метод
        /// </summary>
        public abstract void Method4();


    }
}
