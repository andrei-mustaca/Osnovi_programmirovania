using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Injineer:Employee
    {
        private int n;
        public int N
        {
            set { n = value; }
            get { return n; }
        }
        public Injineer() { }
        public Injineer(string surname,string name,int p,int k,int n):base(surname,name,p,k)
        {
            this.n = n;
        }
        public static Injineer Enter()
        {
            Console.Write("Ввести фамилию:");
            string surname = Console.ReadLine();
            Console.Write("Ввести имя:");
            string name = Console.ReadLine();
            Console.Write("Мин. зарплата:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Коэфициент:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во проектов:");
            int n = Convert.ToInt32(Console.ReadLine());
            return new Injineer(surname, name, p, k,n);
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Кол-во проектов:{n}");
        }
        public override int Cost()
        {
            if(n>10)
            {
                return base.Cost() * (n / 10);
            }
            else
            {
                return base.Cost();
            }
        }
    }
}
