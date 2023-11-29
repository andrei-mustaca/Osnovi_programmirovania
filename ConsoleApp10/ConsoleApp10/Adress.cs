using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Adress
    {
        public string Index;
        public string Country;
        public string City;
        public string Street;
        public string House;
        public string Apartment;

      
        public Adress(string index, string country, string city, string street, string house, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            House = house;
            Apartment = apartment;
        }

        public void Input()
        {
            Console.WriteLine($"Индекс: {Index}\tСтрана:{Country}\tГород:{City}\tУлица:{Street}\tДом:{House}\tКвартира:{Apartment}");
        }
    }
}
