using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    internal class ExcelentPupil:Pupil
    {
        public ExcelentPupil(string surname):base(surname) { }
        public override void Read()
        {
            Console.WriteLine($"Ученик {Surname} читает отлично");
        }
        public override void Write() 
        {
            Console.WriteLine($"Ученик {Surname} пишет очень красиво");
        }
        public override void Study()
        {
            Console.WriteLine($"Ученик {Surname} учится отлично");
        }
        public override void Relax()
        {
            Console.WriteLine($"Ученик {Surname} отдыхает,играя в шахматы");
        }
    }
}
