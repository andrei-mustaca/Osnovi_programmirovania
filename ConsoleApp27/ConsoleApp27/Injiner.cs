using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Injiner:Employee
    {
        private int kol_vo;
        public int Kol_vo
        {
            set { kol_vo = value; }
            get { return kol_vo; }
        }
        public Injiner() { }
        public Injiner(string name, string surname, int year, int month, int day, int p,int kol_vo) :base(name,surname,year,month,day,p)
        {
            this.kol_vo = kol_vo;
        }
        new public static Injiner Enter()
        {
            Console.Write("Ввести имя:");
            string name = Console.ReadLine();
            Console.Write("Ввести фамилию:");
            string surname = Console.ReadLine();
            Console.Write("Ввести год:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввести месяц:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввести день:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввести мин. зарплату:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввести кол-во проектов:");
            int kol_vo = Convert.ToInt32(Console.ReadLine());
            return new Injiner(name, surname, year, month, day, p,kol_vo);
        }
        public override void Print()
        {
            base.Print();
            Console.Write($" Кол-во проектов:{kol_vo}");
        }
        public override double Cost()
        {
            return base.Cost()+(4.8*kol_vo);
        }
    }
}
