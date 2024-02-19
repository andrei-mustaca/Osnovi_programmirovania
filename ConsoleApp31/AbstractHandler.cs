using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    /// <summary>
    /// Абстрактный базовый класс
    /// </summary>
    abstract class AbstractHandler
    {
        /// <summary>
        /// Абстрактный метод открытия 
        /// </summary>
        public abstract void Open();
        /// <summary>
        /// Абстрактный метод создания 
        /// </summary>
        public abstract void Create();
        /// <summary>
        /// Абстрактный метод изменения 
        /// </summary>
        public abstract void Change();
        /// <summary>
        /// Абстрактный метод сохранения
        /// </summary>
        public abstract void Save();

    }
}
