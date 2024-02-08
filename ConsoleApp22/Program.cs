using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввести количество посещений:");
            int n=Convert.ToInt32(Console.ReadLine());
            Web_Sait[] mass = new Web_Sait[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("Ввести адрес веб сайта:");
                string web_adress=Console.ReadLine();
                Console.Write("Ввести IP адрес:");
                string ip=Console.ReadLine();
                Console.Write("Ввести веб браузер:");
                string web_brauser=Console.ReadLine();
                Console.Write("Ввести год:");
                int year=Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести месяц:");
                int month=Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести день:");
                int day=Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести час:");
                int hour=Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести минуту:");
                int minute=Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести секунду:");
                int second=Convert.ToInt32(Console.ReadLine());
                mass[i] = new Web_Sait(web_adress,ip,web_brauser,year,month,day,hour,minute,second);
            }
            foreach(var elem in mass)
            {
                elem.ShowInfo();
                elem.Interval(DateTime.Now.AddDays(-1),DateTime.Now);
            }


            Console.ReadKey();
        }
    }
}
