﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class Pattern1
    {
        public static void PrintPattern1()
        {
         /* 1 2 3 4 5
            1 2 3 4
            1 2 3
            1 2
            1  */

            for(int i=5; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

        }
    }
}
