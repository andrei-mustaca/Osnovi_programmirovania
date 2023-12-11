using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практиум_4
{
    internal class Employee
    {
        public string name;
        public string surname;
        public int p;
        public Employee() { }
        public Employee( string name, string surname, int p)
        {
            this.name = name;
            this.surname = surname;
            this.p = p;
        }
        public override string ToString()
        {
            return $"Имя={name} Фамилия={surname} мин. зарплата={p}";
        }
        public int Capital(int k)
        {
            return k * p;
        }
    }
}
