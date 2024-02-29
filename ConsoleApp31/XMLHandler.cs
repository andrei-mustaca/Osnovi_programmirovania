using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class XMLHandler:AbstractHandler
    {
        /// <summary>
        /// Метод открытия наследуемый от класса AbstractHandler
        /// </summary>
        public override void Open()
        {
            Console.WriteLine("Open document format-XML");
        }
        /// <summary>
        /// Метод создания наследуемый от класса AbstractHandler
        /// </summary>
        public override void Create()
        {
            Console.WriteLine("Creat document format -XML");
        }
        public override void Change()
        {
            Console.WriteLine("Change document format -XML");
        }
        public override void Save()
        {
            Console.WriteLine("Save document format - XML");
        }
    }
}
