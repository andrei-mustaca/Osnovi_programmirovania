using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    internal class Enrollee:Person
    {
        public Enrollee(string name, string surname, int year, int month, int day, string faculty) :base(name,surname,year,month,day,faculty)
        {

        }
        public override void Print()
        {
            Console.WriteLine($"Имя:{Name},Фамилия:{Surname},Дата рождения:{Date},Факультет:{Faculty}");
        }
        public override int Age()
        {
            if(DateTime.Now>Date.AddYears(DateTime.Now.Year-Date.Year))
            {
                return DateTime.Now.Year-Date.Year-1;
            }
            else
            {
                return DateTime.Now.Year - Date.Year;
            }
        }
        public static Enrollee Enter()
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
            return new Enrollee(name,surname,year,month,day,faculty);
        }
    }
}
