using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class School
    {
        /// <summary>
        /// приватное поле описывающее ФИО учащихся
        /// </summary>
        private string fio;
        /// <summary>
        /// свойство поля осуществляющее проверку значений
        /// </summary>
        public string Fio
        {
            set { fio = value; }
            get { return (fio=="")?"Ошибка":fio; }
        }
        /// <summary>
        /// поле описывающее пол учащихся
        /// </summary>
        private string pol;
        /// <summary>
        /// свойство поле осуществляющее проверку значений
        /// </summary>
        public string Pol
        {
            set { pol = value; }
            get { return (pol=="")?"Ошибка":pol; }
        }
        /// <summary>
        /// поле описывающее год рождения учащихся
        /// </summary>
        private int year;
        /// <summary>
        /// свойство поля реализующее проверку значений
        /// </summary>
        public int Year
        {
            set { year = (value < 2017 || value > 2006) ? value : 0; }
            get { return year; }
        }
        /// <summary>
        /// пустой конструктор без параметров
        /// </summary>
        public School() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="fio">ФИО учащихся</param>
        /// <param name="pol">пол учащихся</param>
        /// <param name="year">год рождения учащихся</param>
        public School(string fio,string pol,int year)
        {
            this.fio = Fio;
            this.pol = Pol;
            this.year = Year;
            if(pol=="мужской")
            {
                men++;
            }
            if(pol=="женский")
            {
                women++;
            }
        }
        /// <summary>
        /// статическое поле использующееся как счетчик мужчин и женщин среди учащихся
        /// </summary>
        static public int men,women;
        /// <summary>
        /// статический коструктор присваивающий статическим полям значение 0 
        /// </summary>
        static School()
        {
            men = 0;
            women = 0;
        }
        /// <summary>
        /// метод вывода информации об объектах класса
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"ФИО={fio}\tпол={pol}\tгод рождение={year}");
        }
    }
}
