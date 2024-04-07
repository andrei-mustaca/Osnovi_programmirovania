using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    class Garage
    {
        public List<Bicycle> list1 = new List<Bicycle>();
        public List<Lorry> list2 = new List<Lorry>();
        public List<Car> list3 = new List<Car>();
        public void AddBicycle()
        {
            list1.Add(Bicycle.Enter());
        }
        public void AddLorry()
        {
            list2.Add(Lorry.Enter());
        }
        public void AddCar()
        {
            list3.Add(Car.Enter());
        }
        public void PrintBicycle()
        {
            foreach(var elem in list1)
            {
                elem.Print();
            }
        }
        public void PrintLorry()
        {
            foreach(var elem in list2)
            {
                elem.Print();
            }
        }
        public void PrintCar()
        {
            foreach(var elem in list3)
            {
                elem.Print();
            }
        }
    }
}
