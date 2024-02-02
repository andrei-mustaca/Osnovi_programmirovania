using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести количество сотрудников:");
            int n = Convert.ToInt32(Console.ReadLine());
            Sotrudnic[] mass = new Sotrudnic[n];
            for(int i=0;i<n;i++)
            {
                Console.Write("Ввести табельный номер:");
                int tabel = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести фамилию:");
                string surname = Console.ReadLine();
                Console.Write("Ввести имя:");
                string name = Console.ReadLine();
                Console.Write("Ввести отчество:");
                string fname = Console.ReadLine();
                Console.Write("Ввести год:");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести месяц:");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести день:");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести должность:");
                string dolg = Console.ReadLine();
                Console.Write("Ввести оклад:");
                int oklad = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести пол:");
                string pol = Console.ReadLine();
                Console.Write("Ввести год:");
                int year2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести месяц:");
                int month2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести день:");
                int day2 = Convert.ToInt32(Console.ReadLine());
                mass[i] = new Sotrudnic(tabel,surname,name,fname,year,month,day,dolg,oklad,pol,year2,month2,day2);
            }
            foreach(var elem in mass)
            {
                if(elem.Pol=="Мужской"&&(DateTime.Now.Year-elem.DateP.Year)==30&&(DateTime.Now.Year-elem.Date.Year)==60)
                {
                    elem.ShowInfo();
                }
                if(elem.Pol == "Женский" && (DateTime.Now.Year - elem.DateP.Year) == 30 && (DateTime.Now.Year - elem.Date.Year) == 55)
                {
                    elem.ShowInfo();
                }
            }
            foreach (var elem in mass)
            {
                elem.ShowInfo();
                elem.YearS();
                elem.DayS();
            }
            Console.ReadKey();
        }
    }
}
