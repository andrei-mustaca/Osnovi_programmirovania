﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Point
    {
        public int x;
        public int y;
        public Point(){}
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Input()
        {
            Console.WriteLine($"x={x} y={y}");
        }
        public static int X()
        {
            Console.Write("x=");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static int Y()
        {
            Console.Write("y=");
            int y = Convert.ToInt32(Console.ReadLine());
            return y;
        }
            public double Dlina()
            {
            double dlina = Math.Sqrt(x*2+y*2);
            return dlina;
            }
    }
}
