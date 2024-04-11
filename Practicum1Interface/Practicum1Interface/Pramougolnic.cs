using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum1Interface
{
    class Pramougolnic:Interface1
    {
        public string Name { set; get; }
        public int A { set; get; }
        public int B { set; get; }
        public Pramougolnic(string name,int a,int b)
        {
            Name = name;
            A = a;
            B = b;
        }
        void Interface1.Print()
        {
            Console.WriteLine($"Название:{Name},Сторона 1:{A},Сторона 2:{B}");
        }
        double Interface1.P()
        {
            return 2*(A + B);
        }
        double Interface1.S()
        {
            return A * B;
        }
        public static Pramougolnic Enter()
        {
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введите сторону1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите сторону2:");
            int b = Convert.ToInt32(Console.ReadLine());
            return new Pramougolnic(name,a,b);
        }
    }
}
