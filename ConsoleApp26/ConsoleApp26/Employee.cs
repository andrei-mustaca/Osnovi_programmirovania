using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Employee
    {
        private string surname;
        public string Surname
        {
            set { surname = value; }
            get { return surname; }
        }
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private int p;
        public int P
        {
            set { p = value; }
            get { return p; }
        }
        private int k;
        public int K
        {
            set { k = value; }
            get { return k; }
        }
        public Employee() { }
        public Employee(string surname,string name,int p,int k)
        {
            this.surname = surname;
            this.name = name;
            this.p = p;
            this.k = k;
        }
        public static Employee Enter()
        {
            Console.Write("Ввести фамилию:");
            string surname = Console.ReadLine();
            Console.Write("Ввести имя:");
            string name = Console.ReadLine();
            Console.Write("Мин. зарплата:");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Коэфициент:");
            int k = Convert.ToInt32(Console.ReadLine());
            return new Employee(surname, name, p, k);
        }
        virtual public void Print()
        {
            Console.WriteLine($"Фамилия:{surname} Имя:{name} Мин.зарплата:{p} Коэффициент:{k}");
        }
        virtual public int Cost()
        {
            return p * k;
        }
    }
}
