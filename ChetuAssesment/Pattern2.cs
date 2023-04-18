using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class Pattern2
    {
        public static void PrintPattern2()
        {
            for(int i=5; i>=1; i--)
            {
                for(int j=i; j>=1; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
