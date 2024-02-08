using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Employee:Person
    {
        private string company;
        public string Company
        {
            set { company = value; }
            get { return company; }
        }
        private string job;
        public string Job
        {
            set { job = value; }
            get { return job; }
        }
        public Employee(int age,string name,string surname,string company,string job):base(age,name,surname)
        {
            this.company = company;
            this.job = job;
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine($"Компания:{company} Работа:{job}");
        }
    }
}
