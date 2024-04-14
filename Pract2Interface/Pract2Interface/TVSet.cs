using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2Interface
{
    class TVSet:ISwitchable
    {
        public void Inclusion()
        {
            Console.WriteLine("Включение телевизора");
        }
        public void Shutdown()
        {
            Console.WriteLine("Выключение телевизора");
        }
    }
}
