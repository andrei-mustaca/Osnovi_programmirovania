using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Avto
    {
        public string brand;
        private int skor;
        public string color;
        public Avto() { }
        public Avto(string brand,int skor,string color)
        {
            this.brand = brand;
            Skor = skor;
            this.color = color;
        }
        public int Skor
        {
            set { skor =( value>=20&&value<=120)?value: 0; }
            get { return skor; }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Brand={brand}\tskor={skor}\tcolor={color}");
        }
    }
}
