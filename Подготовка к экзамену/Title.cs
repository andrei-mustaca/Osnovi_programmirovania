using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_к_экзамену
{
    class Title
    {
        public string name;
        public Title() { }
        public Title(string name)
        {
            this.name = name;
        }
        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine($"Название:{name}");
            Console.ResetColor();
        }
    }
}
