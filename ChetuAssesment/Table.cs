using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class Table
    {
        public static void PrintTable()
        {
            Console.WriteLine("Enter first number :");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int n2 = int.Parse(Console.ReadLine());

            for(int i=1; i<=10;  i++)
            {
                Console.WriteLine("Table of" +" "+ n1+" "+ "is: "+n1*i);
                Console.Write("\t\t\t\t\t\t");
                Console.WriteLine("Table of" +" " + n2 +" "+ "is: "+n2*i);
            }
        }
    }
}
