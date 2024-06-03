using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    internal class ClassRom
    {
        public ClassRom()
        {

        }
        public ClassRom(Pupil excelentPupil)
        {

        }
        public ClassRom(Pupil excelentPupil,Pupil badPupil)
        {

        }
        public ClassRom(Pupil excelentPupil,Pupil good1,Pupil badPupil)
        {

        }
        public ClassRom(Pupil badPupil,Pupil good,Pupil excelentPupil,Pupil good1)
        {

        }
        public void Print(Pupil pupil)
        {
            Console.WriteLine();
            Console.WriteLine($"Ученик {pupil.Surname}:");
            pupil.Study();
            pupil.Write();
            pupil.Relax();
            pupil.Read();
        }
    }
}
