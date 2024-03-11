using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Student:Person
    {
       public Student(string name,string surname,int number):base(name,surname,number) { }
        public override void Print()
        {
            Console.WriteLine($"Имя:{Name},Фамилия:{Surname},Number:{Number}");
        }
    }
}
