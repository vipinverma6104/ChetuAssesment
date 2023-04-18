using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class StarSignProgram
    {
        public static void PrintStarSign()
        {
            Console.WriteLine("Enter any count or number :");
            int n=int.Parse(Console.ReadLine());
            string star = "*";

            //first approach using for loop

            //for(int i=1; i<=n; i++)
            //{
            //    Console.Write(star);

            //}
            //Console.WriteLine();

            //Second approach using while loop

            //int i = 1;
            //while (i <= n)
            //{
            //    Console.Write(star);
            //    i++;
            //}
            //Console.WriteLine();

            //third approach using do while loop

            int i = 1;
            do
            {
                Console.Write(star);
                i++;
            } while (i <= n);
            Console.WriteLine();
        }
    }
}
