using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MyApps
{
    internal class Program
    {

        private class ListTask
        {
            private readonly List<float> _listOfStrings = new List<float>(); // Тип данных любой

            public ListTask()
            {
                _listOfStrings.Add(3.14f);
                _listOfStrings.Add(2.71f);
                _listOfStrings.Add(9.8f);
            }
            public void TaskLoop()
            {
                // проверка ввода и вывод результата
                Console.WriteLine("Для прерывания выполнения задачи введите \"quit\"");
                Console.WriteLine("Текущий список: ");
                printList();
                Console.WriteLine("Добавьте значение в список. ");
                var input = Console.ReadLine();
                switch(input)
                {
                    case "quit": return;
                    default:
                        float.TryParse(input, out float result);
                        _listOfStrings.Add(result);
                        break;
                }
                Console.WriteLine("Обновленный список: ");
                printList();
                Console.WriteLine("Добавьте ещё одно значение в список. ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "quit": return;
                    default:
                        float.TryParse(input, out float result);
                        _listOfStrings.Insert(_listOfStrings.Count / 2, result);
                        break;
                }
                Console.WriteLine("Обновленный список: ");
                printList();
            }

            private void printList()
            {
                for(int i=0; i < _listOfStrings.Count; i++)
                {
                    Console.WriteLine("Элемент {0} равен {1}", i, _listOfStrings[i]);
                }
            }
        }

        private class Students
        {
            private Dictionary<string, int> _students = new Dictionary<string, int>();

            public void TaskLoop()
            {
                Console.WriteLine("Для прерывания выполнения задачи введите \"quit\"");
                Console.WriteLine("Введите имя студента");
                var input = Console.ReadLine();
                if (input == "quit") { return; }
                else
                {
                    Console.WriteLine("Введите оценку студента");
                    var input2 = Console.ReadLine();
                    if (input2 == "quit") { return; }
                    else
                    {
                        int.TryParse(input2, out int result);
                        if(result < 2 || result > 5)
                        {
                            Console.WriteLine("Оценка должна быть в диапазоне от 2 до 5");
                            return;
                        }
                        _students.Add(input, result);
                    }
                }
                printDictionary();

                Console.WriteLine("Введите имя студента, чтобы узнать его оценку");
                input = Console.ReadLine();
                if (input == "quit") { return; }
                else
                {
                    if(_students.ContainsKey(input))
                    {
                        Console.WriteLine("Оценка студента {0} - {1}", input, _students[input]);
                    }
                    else
                    {
                        Console.WriteLine("Студента {0} не существует", input);
                    }
                    
                }
            }

            private void printDictionary()
            {
                Console.WriteLine("Текущий список:");
                foreach(KeyValuePair<string, int> kvp in _students) {
                    Console.WriteLine("Студент {0} с оценкой {1}", kvp.Key, kvp.Value);
                }
            }
        }

        private class LinkedListTask
        {
            private class Node
            {
                public int Value;
                public Node Next;
                public Node Before;

            }


            public void TaskLoop()
            {
                Console.WriteLine("Для прерывания выполнения задачи введите \"quit\"");
                Console.WriteLine("Введите число");
                Node node1 = new Node();
                Node node2 = new Node();
                Node node3 = new Node();        
                Node node4 = new Node();    
                var input = Console.ReadLine();
                if (input == "quit") { return; }
                else
                {
                    node1.Value = int.Parse(input);
                    node1.Next = null;
                    node1.Before = null;
                }
                Console.WriteLine("Введите число");
                input = Console.ReadLine();
                if (input == "quit") { return; }
                else
                {
                    node2.Value = int.Parse(input);
                    node2.Next = null;
                    node2.Before = node1;
                    node1.Next = node2;
                }
                Console.WriteLine("Введите число");
                input = Console.ReadLine();
                if (input == "quit") { return; }
                else
                {
                    node3.Value = int.Parse(input);
                    node3.Next = null;
                    node3.Before = node2;
                    node2.Next = node3;
                }
                Console.WriteLine("Введите число");
                input = Console.ReadLine();
                if (input == "quit") { return; }
                else
                {
                    node4.Value = int.Parse(input);
                    node4.Next = null;
                    node4.Before = node3;
                    node3.Next = node4;
                }
                printList(node1);
                printRevertedList(node4);
            }

            private void printList(Node firstNode)
            {
                Node next = firstNode;
                Console.WriteLine("Текущий список в прямом порядке");
                while (next != null) {
                    Console.WriteLine(next.Value);
                    next = next.Next;
                }
            }

            private void printRevertedList(Node lastNode)
            {
                Node before = lastNode;
                Console.WriteLine("Текущий список в обратном порядке");
                while (before != null)
                {
                    Console.WriteLine(before.Value);
                    before = before.Before;
                }
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1,2 or 3 to check task 1,2 or 3");
            int task = int.Parse(Console.ReadLine()); // Используйте tryParse
            switch (task)
            {
                case 1:
                    CheckTaskFirst(); // Выполнение задания в отдельном методе
                    break;
                case 2:
                    CheckTaskSecond();
                    break;
                case 3:
                    CheckTaskThird();
                    break;
            }
        }

        private static void CheckTaskFirst()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }

        private static void CheckTaskSecond()
        {
            var students = new Students();
            students.TaskLoop();
        }

        private static void CheckTaskThird()
        {
            var linkedListTask = new LinkedListTask();
            linkedListTask.TaskLoop();
        }
    }
}
