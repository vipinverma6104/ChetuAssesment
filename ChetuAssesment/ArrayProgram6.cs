using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class ArrayProgram6
    {
        public static void FindOccuranceEach()
        {
            int[] nums = { 12, 22, 32, 45, 55, 16, 17, 12, 22,12 };
            int[] num1 = new int[10];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int r = countNum(nums, nums[i]);
                if(r > 0 && countNum(num1, nums[i])==0)
                {
                    Console.WriteLine($"{nums[i]} found {countNum(nums, nums[i])} times");
                    num1[index] = nums[i];
                    index++;
                }
            }
        }

        public static int countNum(int[] num,int n)
        {
            int count = 0;
            foreach (int i in num)
            {
                if(i==n)
                count++;
            }
            return count;
        }
    }
}
