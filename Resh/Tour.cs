using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resh
{
    class Tour
    {
        private int price;
        public int Price { set; get; }
        private string country;
        public string Country { set; get; }
        private int days;
        public int Days { set; get; }
        public Tour() { }
        public Tour(int price,string country,int days)
        {
            Price = price;
            Country = country;
            Days = days;
        }
        public void TourCalc()
        {
            price = 0;
            country = "Балтийское море";
            Console.WriteLine($"{country},цена;{price}");
        }
        public void TourCalc(string country)
        {
            days = 1;
            price = 50;
            Console.WriteLine($"Страна:{country},Цена:{price}");
        }
        public void TourCalc(string country,int days)
        {
            price = 50 * days;
            Console.WriteLine($"Страна:{country},Цена:{price}");
        }
    }
}
