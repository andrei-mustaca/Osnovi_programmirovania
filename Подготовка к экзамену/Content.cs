using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_к_экзамену
{
    class Content
    {
        public string janr;
        public Content() { }
        public Content(string janr)
        {
            this.janr = janr;
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Жанр:{janr}");
            Console.ResetColor();
        }
    }
}
