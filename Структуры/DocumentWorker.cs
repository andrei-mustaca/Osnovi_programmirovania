using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структуры
{
    class DocumentWorker
    {
        public virtual void Open()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void Edit()
        {
            Console.WriteLine("Редактирование доступно в версии про");
        }
        public virtual void Save()
        {
            Console.WriteLine("Сохранение доступно в версии эксперт");
        }
    }
}
