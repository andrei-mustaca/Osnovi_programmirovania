using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class DateClass
    {
        /// <summary>
        /// поле описывающее поле даты
        /// </summary>
        private DateTime data;
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public DateClass() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="year">год</param>
        /// <param name="month">месяц</param>
        /// <param name="day">день</param>
        public DateClass(int year,int month,int day)
        {
            Data = new DateTime(year,month,day);
        }
        /// <summary>
        /// свойства позволяющие установить или определить значения поля
        /// </summary>
        public DateTime Data
        {
            set { data = value; }
            get { return data; }
        }
        /// <summary>
        /// метод для поределения даты вчерашнего дня
        /// </summary>
        /// <returns>дата вчерашнего дня</returns>
        public DateTime Yesterday()
        {
            return data.AddDays(-1);
        }
        /// <summary>
        /// метод для определения даты завтрашнего дня
        /// </summary>
        /// <returns>дата завтрашнего дня</returns>
        public DateTime Tomorrow()
        {
            return data.AddDays(1);
        }
        /// <summary>
        /// метод определяющий сколько дней осталось до конца месяца
        /// </summary>
        public void Day()
        {
             Console.WriteLine($"Дней до конца месяца:{ DateTime.DaysInMonth(data.Year, data.Month) - data.Day}");
        }
        /// <summary>
        /// метод определяющий интервал между двумя датами в днях
        /// </summary>
        /// <param name="date2">вторая дата</param>
        public void Interval(DateClass date2)
        {
            Console.WriteLine($"Разница между датами в днях:{Data.DayOfYear - date2.Data.DayOfYear}");
        }
    }
}
