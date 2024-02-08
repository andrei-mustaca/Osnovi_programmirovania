using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Notebook:Caet
    {
        private string material;
        public string Material
        {
            set { material = value; }
            get { return material; }
        }
        public Notebook(string name,int k,string material):base(name,k)
        {
            this.material = material;
        }
        public void Print()
        {
            base.ShowInfo();
            Console.WriteLine($"Материал:{material}");
        }
        new public int Cost()
        {
            return base.Cost() + 50;
        }
    }
}
