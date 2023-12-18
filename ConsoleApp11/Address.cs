    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Address
    {
        public int index;
        public string country;
        public string city;
        public string street;
        public string house;
        public string apartament;
        public Address() {}
        public Address(int index, string country, string city, string street, string house, string apartament)
        {
            this.index = index;
            this.country = country;
            this.city = city;
            this.street = street;
            this.house = house;
            this.apartament = apartament;
        }
        public void GetInfo()
        {
            Console.WriteLine($"index={index}  country={country} city={city} street={street} house={house} apartament={apartament}");
        }
    }
}
