using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Teacher:Person
    {
        private string job_title;
        public string Job_title
        {
            set { job_title = value; }
            get { return job_title; }
        }
        private int experience;
        public int Experience
        {
            set { experience = value; }
            get { return experience; }
        }
        public Teacher(string name, string surname, int year, int month, int day, string faculty, string job_title, int experience) :base(name,surname,year,month,day,faculty)
        {
            this.job_title=job_title; 
            this.experience=experience;
        }
        public override void Print()
        {
            Console.WriteLine($"Имя:{Name},Фамилия:{Surname},Дата рождения:{Date},Факультет:{Faculty},Должность:{job_title},Стаж:{experience}");
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
        public static Teacher Enter()
        {
            Console.Write("Ввести имя:");
            string name = Console.ReadLine();
            Console.Write("Ввести фамилию:");
            string surname=Console.ReadLine();
            Console.Write("Ввести год:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввести месяц:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввести день:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ввести факультет:");
            string faculty = Console.ReadLine();
            Console.Write("Ввести должность:");
            string job_title = Console.ReadLine();
            Console.Write("Ввести стаж:");
            int experience =Convert.ToInt32(Console.ReadLine());
            return new Teacher(name,surname,year,month,day,faculty,job_title,experience);
        }
    }
}
