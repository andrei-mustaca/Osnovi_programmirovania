using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Newspaper:Production
    {
        public int coast1;
        public int Coast1
        {
            set { coast1 = value; }
            get { return coast1; }
        }
        public int kol_vo;
        public int Kol_vo
        {
            set { kol_vo = value; }
            get { return kol_vo; }
        }
        public int tiraj;
        public int Tiraj
        {
            set { tiraj = value; }
            get { return tiraj; }
        }
        public Newspaper() { }
        public Newspaper(string name,int coast1, int kol_vo,int tiraj):base(name)
        {
            this.coast1 = coast1;
            this.kol_vo = kol_vo;
            this.tiraj = tiraj;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Название:{Name},Тираж:{tiraj},Кол-во листов:{kol_vo},Цена за 1 лист:{coast1}");
        }
        public override double Cost()
        {
            return (coast1 * kol_vo) * tiraj;
        }

    }
}
