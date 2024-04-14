using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract2Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //DerivedClass dClass = new DerivedClass();
            //dClass.Method();
            //IInterface inteface1 = dClass;
            //inteface1.Method();

            //DerivedClass2 dClass2 = new DerivedClass2();
            //Console.WriteLine($"Реализованный интерфейс PI:{dClass2.PI()}");
            //Console.WriteLine($"Реализованный интерфейс Ret:{dClass2.Ret()}");
            //Console.WriteLine($"Реализованный интерфесй Pow:{dClass2.Pow()}");
            //Console.WriteLine($"Реализованный интерфейс Sqrt:{dClass2.Sqrt()}");

            //DerivedClass3 dClass = new DerivedClass3();
            //IInterface1_3 interface1_1 = dClass;
            //interface1_1.Method1();
            //interface1_1.Method2();
            //interface1_1.Method3();

            //DerivedClass4 dClass = new DerivedClass4();
            //dClass.SayLoud();
            //dClass.Thinking();
            //dClass.SayNormal();

            //List<ISwitchable> list = new List<ISwitchable>();
            //list.Add(new TVSet());
            //list.Add(new PersonalComputer());
            //foreach (var elem in list)
            //{
            //    elem.Inclusion();
            //    elem.Shutdown();
            //}

            //A a1 = new A(5,10);
            //Console.WriteLine($"{a1.Add()}");
            //Console.WriteLine($"{a1.Sub()}");
            //Console.WriteLine($"{a1.Mul()}");
            //Console.WriteLine($"{a1.Div()}");

            //Aa a2 = new Aa(5,10,15);
            //Console.WriteLine($"{a2.Add()}");
            //Console.WriteLine($"{a2.Sub()}");
            //Console.WriteLine($"{a2.Mul()}");
            //Console.WriteLine($"{a2.Div()}");

            //Ab a3 = new Ab();
            //Console.WriteLine($"{a3.Pow()}");
            //Console.WriteLine($"{a3.Sqrt()}");

            Player player = new Player();
            player.Play();
            player.Pause();
            player.Stop();
            player.Record();
            Console.ReadKey();
        }
    }
}
