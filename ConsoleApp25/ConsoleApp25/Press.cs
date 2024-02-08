using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Press
    {
        private int copies;
        public int Copies
        {
            set { copies = value; }
            get { return copies; }
        }
        private string name;
        public string Name
        {
            set { name = value;}
            get { return name;}
        }
        private int price;
        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        public Press() { }
        public Press(int copies)
        {
            this.copies = copies;
        }
        public Press(int copies,string name,int price):this(copies)
        {
            this.name = name;
            this.price = price;
        }
        public int Cost()
        {
            return copies * price;
        }
        public void Output()
        {
            Console.WriteLine($"Кол-во копий:{copies} Имя:{name} Цена:{price}");
        }
    }
}
