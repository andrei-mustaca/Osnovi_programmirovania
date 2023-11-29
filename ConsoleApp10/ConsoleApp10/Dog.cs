using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Dog
    {
        public string Size;
        public int Age;
        public string Color;
        public string Breed;
        public Dog(string breed, string size, int age, string color)
        {
            Breed = breed;
            Size = size;
            Age = age;
            Color = color;
        }

        // Методы класса
        public void Eat()
        {
            Console.WriteLine($"{Breed} is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Breed} is sleeping.");
        }

        public void Sit()
        {
            Console.WriteLine($"{Breed} is sitting.");
        }

        public void Run()
        {
            Console.WriteLine($"{Breed} is running.");
        }
    }
}
