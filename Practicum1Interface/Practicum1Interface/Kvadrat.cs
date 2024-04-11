using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum1Interface
{
    class Kvadrat:Interface1
    {
        public string Name { set; get; }
        public int A { set; get; }
        public Kvadrat(string name,int a)
        {
            Name = name;
            A = a;
        }
        void Interface1.Print()
        {
            Console.WriteLine($"Название:{Name},Сторона:{A}");
        }
        double Interface1.P()
        {
            return A * 4;
        }

        double Interface1.S()
        {
            return A * A;
        }
        public static Kvadrat Enter()
        {
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введите сторону:");
            int a = Convert.ToInt32(Console.ReadLine());
            return new Kvadrat(name,a);
        }
    }
}
