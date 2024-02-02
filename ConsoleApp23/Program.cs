using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp23
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Ввести количество включений:");
            int n = Convert.ToInt32(Console.ReadLine());
            Haus[] mass = new Haus[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Ввести год:");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести месяц:");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести день:");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести час:");
                int hour = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести минуты:");
                int minute = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести секунды:");
                int second = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ввести температурный режим:");
                string mode = Console.ReadLine();
                Console.Write("Ввести температуру:");
                int temperature = Convert.ToInt32(Console.ReadLine());
                mass[i] = new Haus(year, month, day, hour, minute, second, mode, temperature);
            }
            foreach(var elem in mass)
            {
                elem.ShowInfo();
                elem.Update();
            }
            Console.ReadKey();
        }
    }
}
