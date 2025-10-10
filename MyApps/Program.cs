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
            // Задание 1
            Console.WriteLine("Задание 1");
            int current = 0;
            int next = 1;
            int tmp;
            for (int i = 0; i <= 9; i++)
            {
                Console.Write("{0} ", current);
                tmp = current;
                current = next;
                next += tmp;
            }

            // Задание 2
            Console.WriteLine("\n\nЗадание 2");
            for(int i = 2; i <= 20; i++)
            {
                if (i % 2 == 0) { Console.Write("{0} ", i); }
            }

            // Задание 3
            Console.WriteLine("\n\nЗадание 3");
            for(int i = 1; i <= 5; i++)
            {
                for(int j=1; j<=5; j++)
                {
                    Console.Write("{0} ", i * j);
                }
                Console.WriteLine();
            }

            // Задание 4
            Console.WriteLine("\nЗадание 4");
            string password = "qwerty";
            string user_password = "";
            do {
                Console.Write("Введите пароль: ");
                user_password = Console.ReadLine();
                if (user_password != password) { Console.WriteLine("Неправильный пароль"); }
            } while (user_password != password);
        }
    }
}
