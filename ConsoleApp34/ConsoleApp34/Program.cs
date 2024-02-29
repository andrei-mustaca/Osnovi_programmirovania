using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figure> list=new List<Figure>();
            bool flag= true;
            while(flag)
            {
                Console.Write("Введите название фигуры:");
                string figure = Console.ReadLine();
                switch(figure)
                {
                    case "Прямоугольник":
                    case "прямоугольник":
                        list.Add(Rectangle.Enter());
                        break;
                    case "Квадрат":
                    case "квадрат":
                        list.Add(Square.Enter());
                        break;
                    case "Треугольник":
                    case "треугольник":
                        list.Add(Triangle.Enter());
                        break;
                    case "Круг":
                    case "круг":
                        list.Add(Circle.Enter());
                        break;
                    case "конец":Console.Clear(); flag = false;
                        break;
                    default:Console.WriteLine("Введено неверное слово");
                        break;
                }
            }


            foreach(var elem in list)
            {
                elem.Print();
            }
            Console.WriteLine();
            bool flag2 = true;
            while (flag2)
            {
                Console.Write("Введите выполняемое действие:");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "редактирование":
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i].Name == "прямоугольник")
                            {
                                Console.Write("Измените первую сторону:");
                                int side1_iz = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Измените вторую сторону:");
                                int side2_iz = Convert.ToInt32(Console.ReadLine());
                                list[i] = new Rectangle("прямоугольник", side1_iz, side2_iz);
                            }
                            else if (list[i].Name == "круг")
                            {
                                Console.Write("Измените радиус:");
                                int rad_iz = Convert.ToInt32(Console.ReadLine());
                                list[i] = new Circle("круг", rad_iz);
                            }
                            else if (list[i].Name == "квадрат")
                            {
                                Console.Write("Измените сторону:");
                                int side_iz = Convert.ToInt32(Console.ReadLine());
                                list[i] = new Square("квадрат", side_iz);
                            }
                            else
                            {
                                Console.Write("Измените первую сторону:");
                                int side1_iz = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Измените вторую сторону:");
                                int side2_iz = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Измените первую сторону:");
                                int side3_iz = Convert.ToInt32(Console.ReadLine());
                                list[i] = new Triangle("треугольник",side1_iz,side2_iz,side3_iz);
                            }
                        }
                        break;
                    case "удаление":
                        Console.Write("Введите элемент который хотите удалить:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        list.RemoveAt(index);
                        break;
                    case "Периметр фигур":
                        foreach(var elem in list)
                        {
                            Console.WriteLine($"Периметр фигуры:{elem.Perimeter()}");
                        }
                        break;
                    case "Площадь фигур":
                        foreach(var elem in list)
                        {
                            Console.WriteLine($"Площадь фигуры:{elem.Area()}");
                        }
                        break;
                    case "Вывод измененной информации":
                        foreach (var elem in list)
                        {
                            elem.Print();
                        }
                        break;
                    case "конец":flag2 = false;
                        break;
                    default:Console.WriteLine("Введено неправильное действие");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
