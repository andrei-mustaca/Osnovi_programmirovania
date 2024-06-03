using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    internal class Odejda:Tovar
    {
        private int size;
        public int Size { set; get; }
        private string color;
        public string Color { set; get; }
        public Odejda() { }
        public Odejda():base()
        {

        }
    }
}
