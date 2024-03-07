using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Cone:Figure
    {
        public Cone(string name,int r1,int h) : base(name,r1,h)
        {

        }
        public override double S()
        {
            return 3.14 * R1 * (R1+H);
        }
        public override double V()
        {
            return 1/3*3.14*Math.Pow(R1,2)*H;
        }
    }
}
