using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    internal class Good:Pupil
    {
        public Good(string surname):base(surname)
        {

        }
        public override void Read()
        {
            Console.WriteLine($"Ученик {Surname} читает хорошо");
        }
        public override void Write()
        {
            Console.WriteLine($"Ученик {Surname} пишет красиво");
        }
        public override void Study()
        {
            Console.WriteLine($"Ученик {Surname} учится хорошо");
        }
        public override void Relax()
        {
            Console.WriteLine($"Ученик {Surname} отдыхает,смотря телевизор");
        }
    }
}
