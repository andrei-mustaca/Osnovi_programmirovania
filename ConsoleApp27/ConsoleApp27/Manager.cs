using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Manager:Employee
    {
        private int n;
        public int N
        {
            set { n = value; }
            get { return n; }
        }
        public Manager() { }
        public Manager(string name, string surname, int year, int month, int day, int p,int n) :base(name,surname,year,month,day,p)
        {
            this.n = n;
        }
        new public static Manager Enter()
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
            Console.Write("Ввести объем продаж:");
            int n = Convert.ToInt32(Console.ReadLine());
            return new Manager(name, surname, year, month, day, p,n);
        }
        public override void Print()
        {
            base.Print();
            Console.Write($" Объем продаж:{n}");
        }
        public override double Cost()
        {
            if(n>10)
            {
                return base.Cost() + (n / 100);
            }
            else
            {
                return base.Cost();
            } 
        }
    }
}
