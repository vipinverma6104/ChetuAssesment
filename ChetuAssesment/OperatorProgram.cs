using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class OperatorProgram
    {
        public static void CalcOperator()
        {
            Console.WriteLine("Enter any Operator : ");
            string op=Console.ReadLine();
            Console.WriteLine("Enter the first number:");
            int a =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = int.Parse(Console.ReadLine());
            switch(op)
            {
                case "+":
                    Console.WriteLine($"Addition of {a} and {b} is :"+(a + b));
                    break;
                case "-":
                    Console.WriteLine($"Substraction of {a} and {b} is :"+(a - b));
                    break;
                case "*":
                    Console.WriteLine($"Multiplication of {a} and {b} is:"+(a * b));
                    break;
                case "/":
                    Console.WriteLine($"Division of {a} and {b} is :"+(a / b));
                    break;
                case "%":
                    Console.WriteLine($"Modulus of {a} and {b} is :"+(a % b));
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
