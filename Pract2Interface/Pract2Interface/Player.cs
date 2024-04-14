using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2Interface
{
    class Player:IPlayable,IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Игра");
        }
        public void Pause()
        {
            Console.WriteLine("Пауза");
        }
        public void Stop()
        {
            Console.WriteLine("Стоп");
        }
        public void  Record()
        {
            Console.WriteLine("Запись");
        }
    }
}
