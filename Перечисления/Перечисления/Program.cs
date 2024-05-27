using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перечисления
{
    class Program
    {
        enum Months
        {
            Январь,Февраль,Март,Апрель,Май,Июнь,Июль,Август,Сентябрь,Октябрь,Ноябрь,Декабрь
        }
        enum Days
        {
            Понедельник,Вторник,Среда,Четверг,Пятница,Суббота,Воскресенье
        }
        static void Main(string[] args)
        {
            //1
            //Months i;
            //for(i=Months.Январь;i<=Months.Декабрь;i++)
            //{
            //    Console.WriteLine($"{(int)i}    {i}");
            //}

            //2
            //Days d;
            //for(d=Days.Понедельник;d<=Days.Воскресенье;d++)
            //{
            //    Console.WriteLine($"{(int)d}    {d}");
            //}

            //3
            //Console.Write("Введите x:");
            //double x = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Введите y:");
            //double y = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Ответ:{Calc.Rez(x,y)}");

            //4
            //Role.Answer();

            //5
            try
            {
                Console.Write("Введите должность:");
                string worker = Console.ReadLine();
                Accauntat.Post post = (Accauntat.Post)Enum.Parse(typeof(Accauntat.Post), worker);
                Console.Write("Введите количество часов:");
                int hours = Convert.ToInt32(Console.ReadLine());
                if (Accauntat.AskForBonus(post, hours) == true)
                {
                    Console.WriteLine($"Сотруднику положена премия");
                }
                else
                {
                    Console.WriteLine($"Сотруднику премия не положена");
                }
            }
            catch
            {
                Console.WriteLine("Введена неправильная должность");
            }
            Console.ReadKey();
        }
    }
}
