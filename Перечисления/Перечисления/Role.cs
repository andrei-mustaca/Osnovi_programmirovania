using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Перечисления
{
    class Role
    {
        public enum UserRole
        {
            Администратор,
            Модератор,
            Пользователь,
            Гость
        }
        public static void Answer()
        {
            Console.Write("Введите сообщение:");
            string roll = Console.ReadLine();
            if(roll==UserRole.Администратор.ToString())
            {
                Console.WriteLine($"Вы зарегистрированы как администратор");
            }
            else if(roll==UserRole.Гость.ToString())
            {
                Console.WriteLine("Вы зарегистрированы как гость");
            }
            else if(roll==UserRole.Модератор.ToString())
            {
                Console.WriteLine("Вы зарегистрированы как модератор");
            }
            else if(roll==UserRole.Пользователь.ToString())
            {
                Console.WriteLine("Вы зарегистрированы как пользователь");
            }
            else
            {
                Console.WriteLine("Ошибка,неверное сообщение");
            }
        }
    }
}
