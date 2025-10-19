using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // конструктор с 1 аргументом
            Weapon w = new Weapon("sword");
            w.GetInfo();

            // конструктор с 3 аргументами
            Weapon w1 = new Weapon("great sword", 1, 8);
            w1.GetInfo();
            Console.WriteLine(w1.GetDamage());

            // конструктор с 3 аргументами и перепутанными min и max
            Weapon w2 = new Weapon("knife", 10, 2);
            w2.GetInfo();

            // конструктор с 3 аргументами и неправильный min
            Weapon w3 = new Weapon("knife", -1, 2);
            w3.GetInfo();

            // конструктор с 3 аргументами и неправильный max
            Weapon w4 = new Weapon("knife", 1, 1);
            w4.GetInfo();

            // конструктор с 3 аргументами и все неправильно
            Weapon w5 = new Weapon("bow", 0, -8);
            w5.GetInfo();
        }
    }
}
