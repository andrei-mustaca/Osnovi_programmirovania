using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    internal class BadPupil:Pupil
    {
        public BadPupil(string surname):base(surname)
        {

        }
        public override void Read()
        {
            Console.WriteLine($"Ученик {Surname} читает плохо");
        }
        public override void Write()
        {
            Console.WriteLine($"Ученик {Surname} пишет ужасно");
        }
        public override void Study()
        {
            Console.WriteLine($"Ученик {Surname} учится плохо");
        }
        public override void Relax()
        {
            Console.WriteLine($"Ученик {Surname} отдыхает,играя в компьютерные игры");
        }
    }
}
