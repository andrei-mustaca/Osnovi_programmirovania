using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    List<Figure> list = new List<Figure>();
            //    bool flag = true;
            //    while (flag)
            //    {
            //        Console.Write("Ввести нужную фигуру:");
            //        string name = Console.ReadLine();
            //        switch (name)
            //        {
            //            case "Конус":
            //                Console.Write("Ввести радиус:");
            //                int r1 = Convert.ToInt32(Console.ReadLine());
            //                Console.Write("Ввести высоту:");
            //                int h = Convert.ToInt32(Console.ReadLine());
            //                list.Add(new Cone(name, r1, h));
            //                break;
            //            case "Усеченный конус":
            //                Console.Write("Ввести первый радиус:");
            //                int r_1 = Convert.ToInt32(Console.ReadLine());
            //                Console.Write("Ввести второй радиус:");
            //                int r_2 = Convert.ToInt32(Console.ReadLine());
            //                Console.Write("Ввести высоту:");
            //                int h_2 = Convert.ToInt32(Console.ReadLine());
            //                list.Add(new Frustum(name, r_1, h_2, r_2));
            //                break;
            //            case "Выход":
            //                flag = false;
            //                break;
            //            default:
            //                Console.WriteLine("Введено неправильное слово");
            //                break;
            //        }
            //    }
            //    Console.WriteLine("Площадь фигур:");
            //    foreach (Figure f in list)
            //    {
            //        Console.WriteLine($"{f.S():f2}");
            //    }
            //    Console.WriteLine("Объем фигур:");
            //    foreach (Figure f in list)
            //    {
            //        Console.WriteLine($"{f.V():f2}");
            //    }
            //    Console.ReadKey();
            //}
            //catch
            //{
            //    Console.WriteLine("Введены неправильные символы");
            //}


           StudentS studentS = new StudentS();

            Console.ReadKey();
        }
    }
}
