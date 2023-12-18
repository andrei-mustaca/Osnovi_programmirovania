using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private string fam;
        private int kurs;
        public Student() { }
        public Student(string fam, int kurs)
        {
            Fam = fam;
            Kurs = kurs;
        }
        public string Fam
        {
            set { fam = value.ToUpper(); }
            get
            {
                if (fam == "")
                {
                    return "неизвестный";
                }
                else
                {
                    return fam;
                }
            }
        }
        public int Kurs
        {
            set { kurs = (value >= 1 && value <= 4) ? value : 0; }
            get { return kurs; }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Fam={Fam}\tName={Name}\tAge={Age}\tKurs={Kurs}");
        }
        private string name;
        private int age;
        public string Name
        {
            set { name = value.ToUpper(); }
            get
            {
                if (name == "")
                {
                    return "неизвестный";
                }
                else
                {
                    return name;
                }
            }
        }
        public int Age
        {
            set { age = (value >= 15 && value <= 35) ? value : 0; }
            get { return age; }
        }
        public Student(string fam,int kurs,string name,int age) :this(fam,kurs)
        {
            this.age=Age;
            this.name = Name;
        }
    }
}
