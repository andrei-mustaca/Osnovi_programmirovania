using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person.Input("Андрей","Мустяца",17);

            //Adress address = new Adress("1","Россия","Москва","Гагарина","15","7");
            //address.Input();

            Dog neapolitanMastiff = new Dog("Neapolitan Mastiff", "Large", 3, "Gray");
            Dog maltese = new Dog("Maltese", "Small", 2, "White");
            Dog chowChow = new Dog("Chow Chow", "Medium", 4, "Brown");
            Console.WriteLine("Neapolitan Mastiff:");
            neapolitanMastiff.Eat();
            neapolitanMastiff.Sleep();
            neapolitanMastiff.Sit();
            neapolitanMastiff.Run();

            Console.WriteLine("\nMaltese:");
            maltese.Eat();
            maltese.Sleep();
            maltese.Sit();
            maltese.Run();

            Console.WriteLine("\nChow Chow:");
            chowChow.Eat();
            chowChow.Sleep();
            chowChow.Sit();
            chowChow.Run();
            Console.ReadKey();
        }
    }
}
