using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    abstract class Person
    {
        public string Name 
        {
            set { Name = value; }
            get { return Name; } 
        }
        public string Surname
        {
            set { Surname = value; }
            get { return Surname; }
        }
        public DateTime Date
        {
            set { Date = value; }
            get { return Date; }
        }
        public string Faculty
        {
            set { Faculty = value;}
            get { return Faculty; }
        }
        public Person(string name,string surname,int year,int month,int day,string faculty)
        {
            this.Name = name;
            this.Surname = surname;
            Date=new DateTime(year,month,day);
            this.Faculty = faculty;
        }
        public abstract void Print();
        public abstract int Age();
    }
}
