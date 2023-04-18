using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class _2DArrayProgram
    {
        public static void TwoDArray()
        {
            int[,] nums = new int[3, 3];
            nums[0, 0] = 11;
            nums[0, 1] = 12;
            nums[0, 2]= 13;
            nums[1,0] = 14;
            nums[1,1] = 15;
            nums[1,2] = 16;
            nums[2,0]= 17;
            nums[2,1]= 18;
            nums[2,2]= 19;

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(" " + nums[i,j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
