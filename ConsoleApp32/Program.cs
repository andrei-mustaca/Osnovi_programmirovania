using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Production>productions = new List<Production>();
            while (true)
            {
                Console.Write("Ввести метку:");
                string metka=Console.ReadLine();
                switch(metka)
                {
                    case "mag":
                    case "Mag":
                        
                        Production production = new Magazine();
                        break;
                }
            }
        }
    }
}
