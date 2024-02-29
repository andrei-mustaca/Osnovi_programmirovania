using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class TXTHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open document format-TXT");
        }
        public override void Create()
        {
            Console.WriteLine("Creat document format -TXT");
        }
        public override void Change()
        {
            Console.WriteLine("Change document format -TXT");
        }
        public override void Save()
        {
            Console.WriteLine("Save document format - TXT");
        }
    }
}
