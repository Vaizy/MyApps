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
            Console.WriteLine(ConcatenateStrings("first", "player"));
            Console.WriteLine();
            Console.WriteLine(GreetUser("Ivan", 31));
            Console.WriteLine();
            Console.WriteLine(GetInfo("Lorem ipsum dolor sit amet, consectetur adipiscing elit, Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."));
            Console.WriteLine();
            Console.WriteLine(GetSubstring("Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua."));
            Console.WriteLine(GetSubstring("Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat."));
            Console.WriteLine();
            Console.WriteLine(MakeSentence(new string[] { "Lorem", "ipsum", "dolor", "sit" }));
            Console.WriteLine();
            Console.WriteLine(ReplaceWords("Hello world world", "world", "universe"));
        }

        // Задание 1
        public static string ConcatenateStrings(string str1, string str2)
        {
            var builder = new StringBuilder();
            builder.Append(str1);
            builder.Append(str2);
            return builder.ToString();
        }

        // Задание 2
        public static string GreetUser(string name, int age)
        {
            return $"Hello, {name}!\nYou are {age} years old.";
        }

        // Задание 3
        public static string GetInfo(string str)
        {
            return $"Количество символов {str.Length}\nСтрока в верхнем регистре {str.ToUpper()}\nСтрока в нижнем регистре {str.ToLower()}";
        }

        // Задание 4
        public static string GetSubstring(string str)
        {
            return str.Substring(0, 5);
        }

        // Задание 5
        public static string MakeSentence(string[] arrayStr)
        {
            var builder = new StringBuilder();
            foreach(string str in arrayStr)
            {
                builder.Append(str);
                if (arrayStr.Last() != str) builder.Append(" ");
            }
            return builder.ToString();
        }

        // Задание 6
        public static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }

    }
}
