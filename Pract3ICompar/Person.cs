using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3ICompar
{
    internal class Person:IComparable<Person>
    {
        public string Name { set; get; }
        public int Age { set; get; }
        public Person() { }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public int CompareTo(Person person)
        {
            return Name.CompareTo(person.Name);
        }
        public void Print()
        {
            Console.WriteLine($"Имя:{Name},Возраст:{Age}");
        }
    }
}
