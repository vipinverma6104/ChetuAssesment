using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class Pattern3
    {
        public static void PrintPattern3()
        {
            for(int i=1; i<=5;  i++)
            {
                for(int j=5; j>=i;  j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
