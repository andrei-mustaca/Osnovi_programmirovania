using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структуры
{
    class ProDocumentWorker:DocumentWorker
    {
        public override void Open()
        {
            base.Open();
        }
        public override void Edit()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void Save()
        {
            Console.WriteLine("Документ сохранен в старом формате,сохранение в новом доступно в версии эксперт");
        }
    }
}
