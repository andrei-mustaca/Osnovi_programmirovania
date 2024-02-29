using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Magazine:Production
    {
        public int tirag;
        public int Tirag 
        {
            get { return tirag; } 
            set { tirag = value; } 
        }
        public int coast;
        public int Coast
        {
            set { coast = value; }
            get { return coast; }
        }
        public Magazine() { }
        public Magazine(string name,int tirag, int coast):base(name)
        {
            this.tirag = tirag;
            this.coast = coast;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Название:{Name},Тираж:{tirag},Цена за 1 шт:{coast}");
        }
        public override double Cost()
        {
            return tirag * coast;
        }

    }
}
