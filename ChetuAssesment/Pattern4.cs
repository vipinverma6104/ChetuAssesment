using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class Pattern4
    {
        public static void PrintPattern4()
        {
            for(int i=1; i<=5;  i++)
            {
                for(int j=1; j<=5; j++)
                {
                    if (i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
