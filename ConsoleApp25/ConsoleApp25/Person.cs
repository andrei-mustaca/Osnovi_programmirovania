using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Person
    {
        private int age;
        public int Age
        {
            set { age = value; }
            get { return age; }
        }
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
        public Person() { }
        public Person(int age)
        {
            this.age = age;
        }
        public Person(int age,string name):this(age)
        {
            this.name = name;
        }
        public Person(int age,string name,string surname):this(age,surname)
        {
            this.surname = surname;
        }
        public void Print()
        {
            Console.WriteLine($"Возраст:{age}\tИмя:{name}\tФамилия:{surname}");    
        }
    }
}
