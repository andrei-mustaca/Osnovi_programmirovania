using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Student:Person
    {
        private DateTime date;
        public DateTime Date
        {
            set{ date = value; }
            get { return date; }
        }
        private int kurs;
        public int Kurs
        {
            set { kurs = value; }
            get { return kurs; }
        }
        public Student(int age,string name,string surname,DateTime date,int kurs):base(age,name,surname)
        {
            this.date = date;
            this.kurs = kurs;
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine($"Дата рождения:{date} Курс:{kurs}");
        }
    }
}
