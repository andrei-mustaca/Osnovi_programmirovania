using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Magazine:Press
    {
        private string quality;
        public string Quality
        {
            set { quality = value; }
            get { return quality; }
        }
        public Magazine(int copies,string name,int price,string quality):base(copies,name,price)
        {
            this.quality = quality;
        }
        new public int Cost()
        {
            if(quality=="high")
            {
                return base.Cost() + ((base.Cost()/100)*10);
            }
            else if(quality=="low")
            {
                return base.Cost() - ((base.Cost() / 100) * 10);
            }
            else
            {
                return base.Cost();
            }
        }
        new public void Output()
        {
            base.Output();
            Console.Write($" Качество:{quality}");
        }
    }
}
