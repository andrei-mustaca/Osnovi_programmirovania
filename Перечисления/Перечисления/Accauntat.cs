using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перечисления
{
    class Accauntat
    {
        public enum Post
        {
            Manager=200,
            Employee=150,
            Director=250,
            Admin=225
        }
        public static bool AskForBonus(Post worker,int hours)
        {
            switch(worker)
            {
                case Post.Admin:
                    if (hours>=(int)Post.Admin)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case Post.Director:
                    if(hours>=(int)Post.Director)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case Post.Employee:
                    if(hours>=(int)Post.Employee)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case Post.Manager:
                    if(hours>=(int)Post.Manager)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:return false;
            }
        }
    }
}
