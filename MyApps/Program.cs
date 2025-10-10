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
            // Здесь массивы заданий 1-4
            // задание 1
            Console.WriteLine("Задание 1");
            int[] fibonacci_numbers = new int[] { 0, 1, 1, 2, 3, 5, 8, 13};
            foreach(int i in fibonacci_numbers)
            {
                Console.Write("{0}, ", i);
            }
            // задание 2
            Console.WriteLine("\n\nЗадание 2");
            string[] month = new string[]
            {
                "January", "February", "March",
                "April", "May", "June",
                "July", "August", "September",
                "October", "November", "December"
            };
            foreach (string i in month)
            {
                Console.Write("{0}, ", i);
            }
            // задание 3
            Console.WriteLine("\n\nЗадание 3");
            int[,] powers = new int[3, 3]
            {
                {2, 3, 4},
                {4, 9, 16},
                {8, 27, 64}
            };
            for (int i = 0; i < powers.GetLength(0); i++)
            {
                Console.Write("Строка {0}: ", i);
                for (int j = 0; j < powers.GetLength(1); j++)
                {
                    Console.Write("{0}, ", powers[i, j]);
                }
                Console.WriteLine();
            }
            // задание 4
            Console.WriteLine("\nЗадание 4");
            double[][] jagged_arrray = new double[3][]
            {
                new double[] { 1, 2, 3, 4, 5},
                new double[] { Math.E, Math.PI },
                new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) }
            };
            for (int i = 0; i < jagged_arrray.GetLength(0); i++)
            {
                Console.Write("Строка {0}: ", i);
                for (int j = 0; j < jagged_arrray[i].GetLength(0); j++)
                {
                    Console.Write("{0}, ", jagged_arrray[i][j]);
                }
                Console.WriteLine();
            }

            // массивы для заданий 5 и 6.\
            Console.WriteLine("\nЗадание 5");
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            // var result = CopyArrays(array, array2, 2);
            // Выведите результат
            Array.Copy(array, array2, 3);
            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine("Element {0} is {1}", i, array2[i]);
            }

            Console.WriteLine("\nЗадание 6");
            string[] sample = { "", "" };
            // ResizeArray(ref array, /* подставьте число вторым аргументов  */ );
            // Что же будет выведено?
            Array.Resize(ref array, array.Length * 2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element {0} is {1}", i, array[i]);
            }
        }
    }
}
