using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class TuristA:Avtobus
    {
        private int t_cos;
        public int T_cos
        {
            set { t_cos = value; }
            get { return t_cos; }
        }
        public TuristA() { }
        public TuristA(string marka,int n,int cos,int t_cos):base(marka,n,cos)
        {
            this.t_cos = t_cos;
        }
        public static TuristA Enter()
        {
            Console.Write("Ввести марку:");
            string marka = Console.ReadLine();
            Console.Write("Ввести кол-во мест:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Стоимость билета:");
            int cos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Стоимость экскурсии:");
            int t_cos = Convert.ToInt32(Console.ReadLine());
            return new TuristA(marka, n, cos,t_cos);
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стоимость экскурсии:{t_cos}");
        }
        public override int Cost()
        {
            return base.Cost()+t_cos;
        }
    }
}
