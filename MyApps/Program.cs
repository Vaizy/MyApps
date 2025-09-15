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
            Console.Write("Input first operand: ");
            if (!Int32.TryParse(Console.ReadLine(), out var firstOperand))
            {
                Console.WriteLine("Not a number!");
                return;
            }

            Console.Write("Input second operand: ");
            if (!Int32.TryParse(Console.ReadLine(), out var secondOperand))
            {
                Console.WriteLine("Not a number!");
                return;
            }

            Console.Write("Input operator (&, | or ^): ");
            var @operator = Console.ReadLine();
            var result = 0;
            switch (@operator)
            {
                case "&":
                    result = firstOperand & secondOperand;
                    break;
                case "|":
                    result = firstOperand | secondOperand;
                    break;
                case "^":
                    result = firstOperand ^ secondOperand;
                    break;
                default:
                    Console.WriteLine("Wrong operator");
                    return;
            }

            Console.WriteLine("Result in 2: {0}", Convert.ToString(result, 2));
            Console.WriteLine("Result in 10: {0}", Convert.ToString(result, 10));
            Console.WriteLine("Result in 16: {0}", Convert.ToString(result, 16));
        }
    }
}
