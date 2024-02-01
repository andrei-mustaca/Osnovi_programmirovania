using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Sotrudnic
    {
        private int tabel;
        public int Tabel
        {
            set { tabel = (value <= 0 && value > 15) ?0:value; }
            get { return tabel; }
        }
        private string surname;
        public string Surname
        {
            set { surname =value; }
            get { return (surname == "") ? "Ошибка" : surname ; }
        }
        private string name;
        public string Name
        {
            set { name =value; }
            get { return (name == "") ? "Ошибка" : name ; }
        }
        private string fname;
        public string Fname
        {
            set { fname = value; }
            get { return (fname=="" )?"Ошибка":fname; }
        }
        private DateTime date;
        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }
        private string dolg;
        public string Dolg
        {
            set { dolg = value; }
            get { return (dolg=="")?"Ошибка":dolg; }
        }
        private int oklad;
        public int Oklad
        {
            set { oklad = (value<3000&&value>15000)?0:value; }
            get { return oklad; }
        }
        private string pol;
        public string Pol
        {
            set { pol = value; }
            get { return (pol=="")?"Ошибка":pol; }
        }
        private DateTime dateP;
        public DateTime DateP
        {
            set { dateP = value; }
            get { return dateP; }
        }
        public Sotrudnic() { }
        public Sotrudnic(int tabel,string surname,string name,string fname,int year,int month,int day,string dolg,int oklad,string pol,int year2,int month2,int day2)
        {
            Tabel = tabel;
            Surname = surname;
            Name = name;
            Fname = fname;
            Date = new DateTime(year,month,day);
            Dolg = dolg;
            Oklad = oklad;
            Pol = pol;
            DateP = new DateTime(year2,month2,day2);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Таб. номер:{Tabel} ФИО:{Surname} {Name} {Fname} Должность:{Dolg} Оклад:{Oklad}");
            Console.WriteLine($"Дата рождения:{Date.ToShortDateString()} Дата поступления:{DateP.ToShortDateString()}");
        }
        public void YearS()
        {
            if(DateTime.Now<(Date.AddYears(DateTime.Now.Year-Date.Year)))
            {
                Console.WriteLine($"Кол-во полных лет:{DateTime.Now.Year-Date.Year-1}");
            }
            else
            {
                Console.WriteLine($"Кол-во полных лет:{DateTime.Now.Year-Date.Year}");
            }
        }
        public void DayS()
        {
            Console.WriteLine($"Кол-во отработанных дней:{DateTime.Now.DayOfYear-DateP.DayOfYear}");
        }

    }
}
