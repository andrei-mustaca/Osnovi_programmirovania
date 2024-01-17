using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Point
    {
        /// <summary>
        /// Объявление приватных полей x и y
        /// </summary>
        private double x,y;
        /// <summary>
        /// статическая переменная count используемая как счетчик созданных экземпляров
        /// </summary>
        static public int count;
        public static double LengthPoints(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        /// <summary>
        /// нестатический конструктор присвающий полям x и y значение 1.0
        /// </summary>
        public Point()
        {
            x = 1.0;
            y = 1.0;
            count++;
        }
        public Point (double x,double y)
        {
            this.x = x;
            this.y = y;
            count++;
        }
        static Point()
        {
            count = 0;
        }
        public void SetX(double x)
        {
            this.x = x;
        }
        public double GetX()
        {
            return x;
        }
        public void SetY(double y)
        {
            this.y = y;
        }
        public double GetY()
        {
            return y;
        }
        public void Print()
        {
            Console.WriteLine($"x={x}\ty={y}");
        }
        
    }
}
