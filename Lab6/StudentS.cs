using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class StudentS
    {
       public List<Person> students=new List<Person>();
       public void Input()
        {
            Console.Write("Ввести имя:");
            string name=Console.ReadLine();
            Console.Write("Ввести фамилию:");
            string surname=Console.ReadLine();
            Console.Write("Ввести номер:");
            int number=Convert.ToInt32(Console.ReadLine());
            students.Add(new Student(name,surname,number));
        }

        public void Print()
        {
            foreach(var elem in students)
            {
                elem.Print();
            }
        }
        public void P()
        {
            Console.Write("Ввести номер студенческого:");
            int n=Convert.ToInt32((Console.ReadLine()));
            for(int i=0;i<students.Count; i++)
            {
                if (students[i].Number ==n)
                {
                    students[i].Print();
                }
            }
        }
    }
}
