using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract6
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Software> list = new List<Software>();
            //bool flag = true;
            //while(flag)
            //{
            //    Console.WriteLine("[1] Добавление свободного ПО");
            //    Console.WriteLine("[2] Добавление условно-бесплатного ПО");
            //    Console.WriteLine("[3] Добавление платного ПО");
            //    Console.WriteLine("[4] Вывод");
            //    Console.WriteLine("[5] Возможность использования");
            //    Console.WriteLine("[6] Выход");
            //    switch(Console.ReadKey(true).KeyChar)
            //    {
            //        case '1':list.Add(Free.Enter());
            //            break;
            //        case '2':list.Add(FreeUsl.Enter());
            //            break;
            //        case '3':list.Add(Trial.Enter());
            //            break;
            //        case '4':
            //            foreach(var elem in list)
            //            {
            //                elem.Print();
            //                Console.WriteLine();
            //            }
            //            break;
            //        case '5':
            //            foreach(var elem in list)
            //            {
            //                elem.Usable();
            //            }
            //            break;
            //        case '6':return;
            //        default:Console.WriteLine("Ошибка,попробуйте еще раз");
            //            break;
            //    }
            //}

            Garage garage = new Garage();
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("[1] Добавление велосипеда");
                Console.WriteLine("[2] Добавление грузовика");
                Console.WriteLine("[3] Добавление машины");
                Console.WriteLine("[4] Вывод велосипедов");
                Console.WriteLine("[5] Вывод грузовиков");
                Console.WriteLine("[6] Вывод машин");
                Console.WriteLine("[7] Выход");
                switch(Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        garage.AddBicycle();
                        break;
                    case '2':garage.AddLorry();
                        break;
                    case '3':garage.AddCar();
                        break;
                    case '4':garage.PrintBicycle();
                        break;
                    case '5':garage.PrintLorry();
                        break;
                    case '6':garage.PrintCar();
                        break;
                    case '7':return;
                    default:Console.WriteLine("Ошибка,попробуйте еще раз");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
