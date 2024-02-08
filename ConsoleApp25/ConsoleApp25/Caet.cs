using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Caet
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return (name == "") ?"Ошибка":name; }
        }
        private int k;
        public int K
        {
            set { k = (value<12&&value>96) ?0:value; }
            get { return k; }
        }
        public Caet() { }
        public Caet(string name,int k)
        {
            this.name = name;
            this.k = k;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Название:{name} Кол-во:{k}");
        }
        public int Cost()
        {
            return 15 * k;
        }
    }
}
