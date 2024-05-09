using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_к_экзамену
{
    class Address
    {
        private int index;
        public int Index { set; get; }
        private string country;
        public string Country { set; get; }
        private string city;
        public string City { set; get; }
        private string street;
        public string Street { set; get; }
        private int house;
        public int House { set; get; }
        private int apartment;
        public int Apartment { set; get; }
        public Address(int index,string country,string city,string streer,int house,int apartment)
        {
            this.Index = index;
            this.Country = country;
            this.City = city;
            this.Street = streer;
            this.House = house;
            this.Apartment = apartment;
        }
        public void Print()
        {
            Console.WriteLine($"Индекс:{Index}\nСтрана:{Country}\nГород:{City}\nУлица:{Street}\nДом:{House}\nКвартира:{Apartment}");
        }
    }
}
