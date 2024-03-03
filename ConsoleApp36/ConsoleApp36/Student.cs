using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Student:Person
    {
         private int kurs;
        public int Kurs
        {
            set { kurs = value; }
            get { return kurs; }
        }
        public Student(string name, string surname, int year, int month, int day, string faculty,int kurs) :base(name,surname,year,month,day,faculty)
        {
            this.kurs = kurs;
        }
        public override void Print()
        {
            Console.WriteLine($"Имя:{Name},Фамилия:{Surname},Дата рождения:{Date},Факультет:{Faculty},Курс:{kurs}");
        }
        public override int Age()
        {
            if (DateTime.Now > Date.AddYears(DateTime.Now.Year - Date.Year))
            {
                return DateTime.Now.Year - Date.Year - 1;
            }
            else
            {
                return DateTime.Now.Year - Date.Year;
            }
        }
        public static Student Enter()
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
            Console.Write("Ввести факультет:");
            string faculty = Console.ReadLine();
            Console.Write("Ввести курс:");
            int kurs = Convert.ToInt32(Console.ReadLine());
            return new Student(name,surname,year,month,day,faculty,kurs);
        }
    }
}
