using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        static public int count1;
        static public int count2;
        static public int count3;
        static public int count4;
        static public int totalcount;
        public int x;
        public int y;
        static Point()
        {
            count1 = 0;
            count2 = 0;
            count3 = 0;
            count4 = 0;
            totalcount = 0;
        }
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
            if(x>0&&y>0)
            {
                count1++;
            }
            if(x<0&&y>0)
            {
                count2++;
            }
            if(x<0&&y<0)
            {
                count3++;
            }
            if(x>0&&y<0)
            {
                count4++;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"x={x}\ty={y}");
        }
        public static void Count()
        {
            Console.WriteLine($"C1={count1}\tC2={count2}\tC3={count3}\tC4={count4}\tCT={count1+count2+count3+count4}");
        }
    }
}
