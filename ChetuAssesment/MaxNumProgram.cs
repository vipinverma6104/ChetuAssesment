using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class MaxNumProgram
    {
        public static void PrintMaxNum()
        {
            Console.WriteLine("Enter first number :");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int n2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number :");
            int n3=int.Parse(Console.ReadLine());
            if(n1>n2 && n1 > n3)
            {
                    Console.WriteLine("Max number is :"+n1);
            }
            else if(n2>n1 && n2 > n3)
            {
                    Console.WriteLine("Max number is :"+n2);
            }
            else
            {
                Console.WriteLine("Max number is :"+n3);
            }
        }
    }
}
