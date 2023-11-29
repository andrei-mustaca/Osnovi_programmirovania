using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Person
    {
        public string name;
        public string surname;
        public int age;
        public static void Input(string name,string surname,int age)
        {
            Console.WriteLine($"Имя:{name}\t Фамилия:{surname}\t Возраст:{age}");
        }
    }
}
