using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class SortingProgram
    {
        public static void PrintNumSorting()
        {
            Console.WriteLine("Enter first number :");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int n2=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number :");
            int n3=int.Parse(Console.ReadLine());
            Console.WriteLine("Numbers in sorted order :");
            if (n1>n2 && n1 > n3)
            {
                if(n2 > n3)
                {
                    Console.WriteLine("{0} {1} {2}",n1,n2,n3);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}",n1,n3,n2);
                }
            }
            else if(n2>n1 && n2 > n3)
            {
                if(n1> n3)
                {
                    Console.WriteLine("{0} {1} {2}",n2,n1,n3);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}",n2,n3,n1);
                }
            }
            else if(n3>n1 && n3> n2)
            {
                if(n1>n2)
                {
                    Console.WriteLine("{0} {1} {2}",n3,n1,n2);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}",n3,n2,n1);
                }
            }
        }
    }
}
