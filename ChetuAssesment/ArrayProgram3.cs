using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class ArrayProgram3
    {
        public static void PrintLargestNumInArray()
        {
            int[] nums= new int[6];
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Enter number for {0} index",i);
                int n=int.Parse(Console.ReadLine());
                nums[i]=n;
            }
            int max = nums[0];
            for(int i=0; i < nums.Length; i++)
            {
                if (nums[i]>max)
                {
                    max = nums[i];
                }
            }
            Console.WriteLine("The largest number is :"+max);
        }
    }
}
