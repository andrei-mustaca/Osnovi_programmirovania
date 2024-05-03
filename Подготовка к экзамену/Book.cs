using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Подготовка_к_экзамену
{
    class Book
    {
        public Title t;
        public Content c;
        public Author a;
        public Book() { }
        public Book(string name,string janr,string fio)
        {
            this.t = new Title(name);
            this.c = new Content(janr);
            this.a = new Author(fio);
        }
    }
}
