using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практиум_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Figuries figur1= new Figuries();
            //figur1.name = "квадрат";
            //figur1.side1=5; 
            //figur1.ShowInfo();
            //figur1.S();
            //figur1.P();

            //Figuries figure2=new Figuries("прямоугольник  ",8,5);
            //figure2.ShowInfo();

            //Console.WriteLine("name:");
            //string name=Console.ReadLine();
            //Console.WriteLine("side1=");
            //double side1=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("side2=");
            //double side2=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("side3=");
            //double side3=Convert.ToDouble(Console.ReadLine());
            //Figuries figure3 = new Figuries(name,side2,side2,side3);
            //figure3.ShowInfo();
            //Console.WriteLine($"S={figure3.S()} P={figure3.P()}");




            //Employee emp1= new Employee();
            //emp1.name = "Иван";
            //emp1.surname = "Петров";
            //emp1.p = 1200;
            //Console.WriteLine($"{emp1.ToString()}");
            //emp1.Capital();

            Console.Write("Имя=");
            string name=Console.ReadLine();
            Console.Write("Фамилия=");
            string surname=Console.ReadLine();
            Console.Write("мин. зарплата=");
            int min=Convert.ToInt32(Console.ReadLine());
            Employee emp2 = new Employee(name,surname,min);
            Console.WriteLine($"{emp2.ToString()}");
            Console.Write("k=");
            int k=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Доход={emp2.Capital(k)} р");
            Console.ReadKey();
        }
    }
}
