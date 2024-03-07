using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Frustum:Figure
    {
        private int r2;
        public int R2
        { set; get; }
        public Frustum(string name,int r1,int h,int r2):base(name,r1,h)
        {
            R2 = r2;
        }
        public override double S()
        {
            return 3.14 * (R1 + R2) * Math.Sqrt(Math.Pow(R2-R1,2)+Math.Pow(H,2))+3.14+Math.Pow(R1,2)+3.14+Math.Pow(R2,2);
        }
        public override double V()
        {
            return 1 / 3 * 3.14 + H * (Math.Pow(R1, 2) + R1 * R2 + Math.Pow(R2, 2));
        }
    }
}
