using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class MedProc
    {
        /// <summary>
        /// поле описывающее дату медицинской процедуры
        /// </summary>
        DateTime date;
        /// <summary>
        /// свойство поля Date позволяющее установить или определить значение поля
        /// </summary>
        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public MedProc() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="year">год</param>
        /// <param name="month">месяц</param>
        /// <param name="day">день</param>
        /// <param name="hours">час</param>
        /// <param name="minute">минута</param>
        /// <param name="seconds">секунда</param>
        public MedProc(int year, int month, int day, int hours, int minute, int seconds)
        {
            Date = new DateTime(year, month, day, hours, minute, seconds);
        }
    }
}
