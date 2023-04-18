using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class LowestNumProgram
    {
        public static void PrintLowestNum()
        {
            Console.WriteLine("Enter first number :");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int n2=int.Parse(Console.ReadLine());
            if(n1<n2)
            {
                Console.WriteLine("Lowest number is :"+n1);
            }
            else
            {
                Console.WriteLine("Lowest number is :"+n2);
            }
        }
    }
}
