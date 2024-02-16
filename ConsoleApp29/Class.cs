using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    /// <summary>
    /// Абстрактный класс Class наследуемый от класса BClass
    /// </summary>
    abstract class CClass:BClass
    {
        /// <summary>
        /// Абстрактный метод для приветствия 
        /// </summary>
        public abstract string Method3(string hello);
    }
}
