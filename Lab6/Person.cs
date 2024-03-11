using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    abstract class Person
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public int Number {  get; set; }
        public Person(string name,string surname,int number)
        {
            Name = name;
            Surname = surname;
            Number = number;
        }
        public abstract void Print();
    }
}
