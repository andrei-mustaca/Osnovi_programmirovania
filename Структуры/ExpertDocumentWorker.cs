using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структуры
{
    class ExpertDocumentWorker:ProDocumentWorker
    {
        public override void Edit()
        {
            base.Edit();
        }
        public override void Open()
        {
            base.Open();
        }
        public override void Save()
        {
            Console.WriteLine("Файл сохранен в новом формате ");
        }
    }
}
