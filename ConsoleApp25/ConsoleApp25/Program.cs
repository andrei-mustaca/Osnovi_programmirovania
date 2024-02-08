using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1
            //Person person = new Person(17,"Андрей","Мустяца");
            //person.Print();
            //Employee emp1 = new Employee(17,"Андрей","Мустяца","Microsoft","Программист");
            //emp1.Print();
            //Person emp2 = new Employee(17,"Андрей","Мустяца","Google","Программист");
            //emp2.Print();
            //Console.WriteLine("Введите дату рождения:");
            //DateTime date = DateTime.Parse(Console.ReadLine());
            //Student st1 = new Student(17,"Андрей","Мустяца",date,2);
            //st1.Print();

            //Задача 2
            //Console.Write("Ввести кол-во копий:");
            //int copies = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ввести название:");
            //string name = Console.ReadLine();
            //Console.Write("Ввести цену:");
            //int price = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ввести качество:");
            //string quality = Console.ReadLine();
            //Press press1 = new Press(copies,name,price);
            //press1.Output();
            //Console.WriteLine($"Цена:{press1.Cost()}");
            //Magazine mag2 = new Magazine(copies,name,price,quality);
            //mag2.Output();
            //Console.WriteLine($"Цена:{mag2.Cost()}");
            //Press press2 = new Magazine(copies,name,price,quality);
            //press2.Output();

            //Задача 3
            Console.Write("Введите название:");
            string name = Console.ReadLine();
            Console.Write("Введиет кол-во листов:");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите название материала:");
            string material = Console.ReadLine();
            Caet caet1 = new Caet();
            caet1.ShowInfo();
            Console.WriteLine($"{caet1.Cost()}");
            Notebook not1 = new Notebook(name,k,material);
            Console.Write($"Цена:{not1.Cost()}");
            Console.ReadKey();
        }
    }
}
