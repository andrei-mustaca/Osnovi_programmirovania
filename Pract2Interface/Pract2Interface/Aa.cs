using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2Interface
{
    class Aa:A
    {
        public int Z { set; get; }
        public Aa(int x,int y,int z):base(x,y)
        {
            this.Z = z;
        }
        public override int Add()
        {
            return base.Add()+Z;
        }
        public override int Sub()
        {
            return base.Sub()-Z;
        }
        public override int Mul()
        {
            return base.Mul()*Z;
        }
        public override int Div()
        {
            return base.Div()/Z;
        }
    }
}
