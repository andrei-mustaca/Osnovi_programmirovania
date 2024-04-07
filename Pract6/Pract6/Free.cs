using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    class Free:Software
    {
        public Free(string manufacturer,string name):base(manufacturer,name) { }
        public override void Print()
        {

            Console.WriteLine($"Название:{Name}");
            Console.WriteLine($"Производитель");
        }
        public override void Usable()
        {
            Console.WriteLine(Name);
        }
        public static Free Enter()
        {
            Console.Write("Введите производителя:");
            string manufacturer = Console.ReadLine();
            Console.Write("Введите имя:");
            string name = Console.ReadLine();
            return new Free(manufacturer,name);
        }
    }
}
