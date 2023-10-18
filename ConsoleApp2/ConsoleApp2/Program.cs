using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<256;i++)
            {
                Console.WriteLine($"Код {i}{(char)i}");
            }
            Console.ReadKey();
        }
    }
}
