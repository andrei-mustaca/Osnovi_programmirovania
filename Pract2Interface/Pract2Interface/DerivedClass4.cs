using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2Interface
{
    class DerivedClass4:IInterface4_1,IInterface4_2
    {
        public void SayLoud()
        {
            Console.WriteLine("Говорит громко - Я люблю программирование!");
        }
        public void Thinking()
        {
            Console.WriteLine("Думает - А С# больше всего");
        }
        public void SayNormal()
        {
            Console.WriteLine("Говорит нормально - Меньше люблю компьютерные игры");
        }
    }
}
