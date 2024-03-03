using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>();
            bool flag = true;
            while(flag)
            {
                Console.Write("Введите должность:");
                string s = Console.ReadLine();
                switch(s)
                {
                    case "Абитуриент":list.Add(Enrollee.Enter());
                        break;
                    case "Студент":list.Add(Student.Enter());
                        break;
                    case "Преподователь":list.Add(Teacher.Enter());
                        break;
                    case "Конец":flag = false;
                        break;
                    default:Console.Write("Введено неправильное слово");
                        break;
                }
            }
            foreach(var elem in list)
            {
                elem.Print();
            }
            Console.WriteLine();
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].Age()>18&&list[i].Age()<25)
                {
                    list[i].Print();
                }
            }
            Console.ReadKey();
        }
    }
}
