using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resh
{
    class Tovar
    {
        private string name;
        public string Name 
        {
            set;
            get; 
        }
        private int price;
        public int Price
        {
            set { price = (value >= 1 && value <= 20) ?value:0; }
            get { return price; }
        }
        private int kvo;
        public int Kvo
        {
            set { kvo = (value>=0&&value<=10)?value:0; }
            get { return kvo; }
        }
        public Tovar() { }
        public Tovar(string name,int price,int kvo)
        {
            Name = name;
            Price = price;
            Kvo = kvo;
        }
        public int Cost()
        {
            return Price * Kvo;
        }
        public static int CostKvo(List<Tovar>list)
        {
            int sum = 0;
            foreach(var elem in list)
            {
                sum = sum + (elem.Price*elem.Kvo);
            }
            return sum;
        }
    }
}
