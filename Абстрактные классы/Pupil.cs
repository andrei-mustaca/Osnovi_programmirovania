using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Абстрактные_классы
{
    abstract class Pupil
    {
        public string Surname { set; get; }
        public Pupil() { }
        public Pupil(string surname)
        {
            Surname = surname;
        }
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();
    }
}
