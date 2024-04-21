using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Pract4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Main> list = new List<Main>();
            string[] lines = File.ReadAllLines(@"C:\Users\andre\OneDrive\Документы\GitHub\Osnovi_programmirovania\Pract4\Pract4.txt");
            foreach(var line in lines)
            {
                string[] elem = line.Split(';');
                string name = elem[0];
                switch(name)
                {
                    case "Преподователь":list.Add(new Prepod(elem[1],elem[2],elem[3]));
                        break;
                    case "Студент":list.Add(new Student(elem[1],elem[2],int.Parse(elem[3])));
                        break;
                    case "Работник":list.Add(new Worker(elem[1],elem[2],DateTime.Parse(elem[3]),DateTime.Parse(elem[4])));
                        break;
                }
            }
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("[1] Вывод информации");
                Console.WriteLine("[2] Вывод обновленных пропусков");
                Console.WriteLine("[3] Вывод анулированных пропусков");
                switch(Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        foreach(var elem in list)
                        {
                            elem.Print();
                        }
                        break;
                    case '2':
                        foreach (var elem in list)
                        {
                            elem.RegY();
                        }
                        break;
                    case '3':
                        foreach (var elem in list)
                        {
                            elem.RegN();
                        }
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
