using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Web_Sait
    {
        private string web_adress;
        public string Web_adress
        {
            set { web_adress = value; }
            get { return (web_adress == "") ?"Ошибка":web_adress; }
        }
        private string ip;
        public string Ip
        {
            set { ip = value; }
            get { return (ip=="") ?"Ошибка":ip; }
        }
        private string web_brauser;
        public string Web_brauser
        {
            set { web_brauser = value; }
            get { return (web_brauser=="") ?"Ошибка":web_brauser; }
        }
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
        public Web_Sait() { }
        public Web_Sait(string web_adress,string ip,string web_brauser,int year,int month,int day,int hour,int minute,int second)
        {
            Web_adress = web_adress;
            Ip = ip;
            Web_brauser = web_brauser;
            Date = new DateTime(year,month,day);
            Time = new DateTime(year,month,day,hour,minute,second);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Адрес:{Web_adress} IP адрес:{Ip} Дата посещения:{Date:dddd} {Date.ToShortDateString()} Время посещения:{Time.ToLongTimeString()}");
        }
        public void Interval(DateTime date1,DateTime date2)
        {
            if(date1<Time&&date2>Time)
            {
                ShowInfo();
            }
        }
    }
}
