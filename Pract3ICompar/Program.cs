using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract3ICompar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Person> people = new List<Person>();
            //Console.Write("Введите размер массива:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for(int i=0;i<n;i++)
            //{
            //    Console.Write("Введите имя:");
            //    string name = Console.ReadLine();
            //    Console.Write("Введите возраст:");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    people.Add(new Person(name,age));
            //}
            //foreach (var elem in people)
            //{
            //    elem.Print();
            //}
            //people.Sort();
            //Console.WriteLine("Отсортированный список:");
            //foreach (var elem in people)
            //{
            //    elem.Print();
            //}

            //List<Auto_shop>auto_Shops=new List<Auto_shop>();
            //Console.Write("Введите размер массива:");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Введите id:");
            //    int id =Convert.ToInt32( Console.ReadLine());
            //    Console.Write("Введите марку:");
            //    string name = Console.ReadLine();
            //    Console.Write("Введите макс.скорость:");
            //    int maxspeed = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Введите цену:");
            //    int price = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Введите скидку:");
            //    int skidka = Convert.ToInt32(Console.ReadLine());
            //    auto_Shops.Add(new Auto_shop(id,name,maxspeed,price,skidka));
            //}
            //foreach (var elem in auto_Shops)
            //{
            //    elem.Print();
            //}
            //auto_Shops.Sort();
            //Console.WriteLine("Отсортированный список:");
            //foreach (var elem in auto_Shops)
            //{
            //    elem.Print();
            //}

            //List<Figure> list = new List<Figure>();
            //bool flag = true;
            //while (flag)
            //{
            //    Console.Write("Введите название фигуры:");
            //    string figure = Console.ReadLine();
            //    switch (figure)
            //    {
            //        case "Прямоугольник":
            //        case "прямоугольник":
            //            list.Add(Rectangle.Enter());
            //            break;
            //        case "Квадрат":
            //        case "квадрат":
            //            list.Add(Square.Enter());
            //            break;
            //        case "Треугольник":
            //        case "треугольник":
            //            list.Add(Triangle.Enter());
            //            break;
            //        case "Круг":
            //        case "круг":
            //            list.Add(Circle.Enter());
            //            break;
            //        case "конец":
            //            Console.Clear(); flag = false;
            //            break;
            //        default:
            //            Console.WriteLine("Введено неверное слово");
            //            break;
            //    }
            //}


            //foreach (var elem in list)
            //{
            //    elem.Print();
            //}
            //list.Sort();
            //Console.WriteLine("Отсортированный список:");
            //foreach (var elem in list)
            //{
            //    elem.Print();
            //}

            List<Goods> list = new List<Goods>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("[1] Добавить продукт");
                Console.WriteLine("[2] Добавить комплект");
                Console.WriteLine("[3] Добавить партию");
                Console.WriteLine("[4] Вывод");
                Console.WriteLine("[5] Поиск просроченного товара");
                Console.WriteLine("[6] Сортировка коллекции по цене");
                Console.WriteLine("[7] Выход");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case '1':
                        list.Add(Product.Enter());
                        break;
                    case '2':
                        list.Add(Kit.Enter());
                        break;
                    case '3':
                        list.Add(Party.Enter());
                        break;
                    case '4':
                        foreach (var elem in list)
                        {
                            elem.Print();
                            Console.WriteLine();
                        }
                        break;
                    case '5':
                        Console.WriteLine("Просроченные товары:");
                        foreach (var elem in list)
                        {
                            elem.Deadline();
                        }
                        break;
                    case '6':list.Sort();
                        foreach (var elem in list)
                        {
                            elem.Print();
                            Console.WriteLine();
                        }
                        break;
                    case '7': return;
                    default:
                        Console.WriteLine("Ошибка,попробуйте еще раз");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
