using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структуры
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //MyClass myClass = new MyClass();
            //myClass.change = "не изменено";
            //MyStruct myStruct = new MyStruct();
            //myStruct.change = "не изменено";
            //ClassTaker(myClass);
            //StructTaker(myStruct);
            //Console.WriteLine($"Объект класса:{myClass.change}");
            //Console.WriteLine($"Объект структуры:{myStruct.change}");

            //Задание 2
            //List<Notebook> list = new List<Notebook>();
            //bool flag = true;
            //while (flag)
            //{
            //    Console.WriteLine($"[1]-Добавление элемента\n[2]-Вывод всех элементов\n[3]-Выход");
            //    switch (Console.ReadKey(true).KeyChar)
            //    {
            //        case '1':
            //            list.Add(Notebook.Enter());
            //            break;
            //        case '2':
            //            foreach (var elem in list)
            //            {
            //                elem.Print();
            //            }
            //            break;
            //        case '3': return;
            //    }
            //}

            //Задача 3
            //List<Book> list = new List<Book>();
            //bool flag = true;
            //while (flag)
            //{
            //    Console.WriteLine($"[1]-Добавление элемента\n[2]-Вывод всех элементов\n[3]-Выход");
            //    switch (Console.ReadKey(true).KeyChar)
            //    {
            //        case '1':
            //            list.Add(Book.Enter());
            //            break;
            //        case '2':
            //            foreach (var elem in list)
            //            {
            //                elem.Print();
            //            }
            //            break;
            //        case '3': return;
            //    }
            //}

            //Задача 11
            string keypro = "1234";
            string keyexpert = "12345";
            Console.Write("Введите ключ про:");
            string pro = Console.ReadLine();
            Console.Write("Введите ключ эксперт:");
            string expert = Console.ReadLine();
            if(keypro==pro&&keyexpert!=expert)
            {
                ProDocumentWorker proDocumentWorker = new ProDocumentWorker();
                proDocumentWorker.Open();
                proDocumentWorker.Edit();
                proDocumentWorker.Save();
            }
            else if(keyexpert==expert)
            {
                ExpertDocumentWorker expertDocumentWorker = new ExpertDocumentWorker();
                expertDocumentWorker.Open();
                expertDocumentWorker.Edit();
                expertDocumentWorker.Save();
            }
            else
            {
                DocumentWorker documentWorker = new DocumentWorker();
                documentWorker.Open();
                documentWorker.Edit();
                documentWorker.Save();
            }
            Console.ReadKey();
        }
        public static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        public static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
}
