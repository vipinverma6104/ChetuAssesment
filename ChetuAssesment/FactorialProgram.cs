using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class FactorialProgram
    {
        public static void PrintFactorial()
        {
            Console.WriteLine("Enter any number :");
            int n=int.Parse(Console.ReadLine());
            int fact = 1;
            for(int i=1; i<=n; i++)
            {
                fact= fact*i;
            }
            Console.WriteLine($"Factorial of {n} is :"+fact);
        }
    }
}
