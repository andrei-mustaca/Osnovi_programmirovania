using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AbstractHandler>list = new List<AbstractHandler>();
            //bool flag = true;
            while (true)
            {
                Console.Write("Введите метку:");
                string metka = Console.ReadLine();
                switch(metka)
                {
                    case "XML":
                    case "xml":
                        //list.Add(new XMLHandler());
                        AbstractHandler xml = new XMLHandler();
                        xml.Open();
                        xml.Create();
                        xml.Change();
                        xml.Save();
                        break;
                    case "TXT":
                    case "txt":
                        //list.Add(new TXTHandler());
                        AbstractHandler txt=new TXTHandler();
                        txt.Open();
                        txt.Create();
                        txt.Change();
                        txt.Save();
                               break;
                    case "DOC":
                    case "doc":
                        //list.Add(new DOCHandler());
                        AbstractHandler doc=new DOCHandler();
                        doc.Open();
                        doc.Create();
                        doc.Change();
                        doc.Save();
                               break;
                    case "q":
                    case "Q":return;

                    default: Console.WriteLine("Такой метки не существует");
                             //flag = false;
                               break;
                }
            }
            //foreach (var elem in list)
            //{
            //    elem.Open();
            //    elem.Create();
            //    elem.Change();
            //    elem.Save();
            //}
            Console.ReadKey();
        }
    }
}
