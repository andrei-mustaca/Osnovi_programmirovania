using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Haus
    {
        private DateTime date;
        public DateTime Date
        {
            set { date = value; }
            get { return date; }
        }
        private DateTime time;
        public DateTime Time
        {
            set { time = value; }
            get { return time; }
        }
        private string mode;
        public string Mode
        {
            set { mode = value; }
            get { return (mode == "") ?"Ошибка":mode;}
        }
        private int temperature;
        public int Temperature
        {
            set { temperature = (value<15&&value>30) ?0:value; }
            get { return temperature; }
        }
        public Haus() { }
        public Haus(int year,int month,int day,int hour,int minute,int second,string mode,int temperature)
        {
            Date = new DateTime(year, month, day);
            Time = new DateTime(year, month, day,hour,minute,second);
            Mode = mode;
            if(mode=="отопление"&&temperature>20)
            {
                Temperature = temperature;
            }
            else if(mode=="отопление"&&temperature<20)
            {
                Temperature=0;
            }
            else if(mode=="охлаждение"&&temperature<20)
            {  
                Temperature = temperature; 
            }
            else
            {
                Temperature = 0;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Дата включения:{Date.ToShortDateString()} Время включения:{Time.ToLongTimeString()} Температур. режим:{Mode} Заданная температура:{Temperature} До включения кондиционера:{(Time-DateTime.Now).TotalMinutes}");
        }
        public void Update()
        {
            if(Date.DayOfYear>DateTime.Now.DayOfYear)
            {
                Console.WriteLine($"Дата включения:{Date.ToShortDateString()} Время включения:{Time.ToLongTimeString()} Температур. режим:{Mode} Заданная температура:{Temperature}");
            }
            
        }
    }
}
