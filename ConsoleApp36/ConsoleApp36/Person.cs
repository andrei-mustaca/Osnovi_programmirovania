using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    abstract class Person
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
        private string faculty;
        public string Faculty
        {
            set { faculty = value; }
            get { return faculty; }
        }
        public Person(string name, string surname, int year, int month, int day, string faculty)
        {
            this.name = name;
            this.surname = surname;
            this.date = new DateTime(year, month, day);
            this.faculty = faculty;
        }
        public abstract void Print();
        public abstract int Age();
    }
}
