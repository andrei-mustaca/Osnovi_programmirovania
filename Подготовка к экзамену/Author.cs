using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_к_экзамену
{
    class Author
    {
        public string fio;
        public Author() { }
        public Author(string fio)
        {
            this.fio = fio;
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"ФИО автора:{fio}");
            Console.ResetColor();
        }
    }
}
