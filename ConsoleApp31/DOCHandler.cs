﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class DOCHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Open document format-DOC");
        }
        public override void Create()
        {
            Console.WriteLine("Creat document format -DOC");
        }
        public override void Change()
        {
            Console.WriteLine("Change document format -DOC");
        }
        public override void Save()
        {
            Console.WriteLine("Save document format - DOC");
        }
    }
}
