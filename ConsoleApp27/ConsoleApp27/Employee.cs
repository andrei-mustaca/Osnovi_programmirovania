using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Employee
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        private string surname;
        public string Surname
        {
            set { surname = value; }
            get { return surname; }
        }
        private DateTime date;
        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }
        private int p;
        public int P
        {
            set { p = value; }
            get { return p; }
        }
        public Employee() { }
        public Employee(string name,string surname,int year,int month,int day,int p)
        {
            this.name = name;
            this.surname = surname;
            this.date = new DateTime(year, month, day);
            this.p = p;
        }
        public static Employee Enter()
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
            return new Employee(name,surname,year,month,day,p);
        }
        public virtual void Print()
        {
            Console.WriteLine($"Имя:{name},Фамилия:{surname},Дата рождения:{date},Мин. зарплата:{p}");
        }
        public virtual double Cost()
        {
            Console.Write("Ввести коэфициент:");
            int k = Convert.ToInt32(Console.ReadLine());
            return k * p;
        }
    }
}
