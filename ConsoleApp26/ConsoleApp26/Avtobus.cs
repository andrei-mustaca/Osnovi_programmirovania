using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Avtobus
    {
        private string marka;
        public string Marka
        {
            set { marka = value; }
            get { return marka; }
        }
        private int n;
        public int N
        {
            set { n = value; }
            get { return n; }
        }
        private int cos;
        public int Cos
        {
            set { cos = value; }
            get { return cos; }
        }
        public Avtobus() { }
        public Avtobus(string marka,int n,int cos)
        {
            this.marka = marka;
            this.n = n;
            this.cos = cos;
        }
        public static Avtobus Enter()
        {
            Console.Write("Ввести марку:");
            string marka = Console.ReadLine();
            Console.Write("Ввести кол-во мест:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Стоимость билета:");
            int cos = Convert.ToInt32(Console.ReadLine());
            return new Avtobus(marka, n,cos);
        }
        virtual public void Print()
        {
            Console.WriteLine($"Марка:{marka} Кол-во мест:{n} Стоимость билета:{cos}");
        }
        virtual public int Cost()
        {
            return n * cos;
        }
    }
}
