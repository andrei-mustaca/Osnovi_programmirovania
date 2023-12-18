using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Computer
    {
        public string model;
        private int ram;
        private int hdd;
        public Computer() { }
        public Computer(string model,int ram,int hdd)
        {
            this.model = model;
            Ram = ram;
            HDD = hdd;
        }
        public int Ram
        {
            set { ram = (value>=2&&value<=32) ?value:0; }
            get { return ram; }
        }
        public int HDD
        {
            set { hdd = (value>=200&&value<=2000) ?value:0; }
            get { return hdd; }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"model={model}\tram={ram}\thdd={hdd}");
        }
    }
}
