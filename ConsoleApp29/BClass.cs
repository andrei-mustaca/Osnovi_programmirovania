using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    /// <summary>
    /// Абстрактный класс BClass  наследуемый от класса AClass
    /// </summary>
    abstract class BClass:AClass_Method__
    {
        /// <summary>
        /// Абстрактный класс для сложения двух чисел
        /// </summary>
        /// <param name="a">первое число</param>
        /// <param name="b">второе число</param>
        /// <returns>сумма двух значений</returns>
        public abstract int Method2(int a,int b);
    }
}
