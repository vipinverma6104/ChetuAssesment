using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class ArrayProgram1
    {
        public static void PrintSumInArray()
        {
            int[] nums= new int[5];
            for(int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine("Enter number for {0} index",i);
                int n=int.Parse(Console.ReadLine());
                nums[i]=n;
            }
            //Calculate sum
            int sum = 0;
            foreach(int num in nums)
            {
                sum += num;

            }
            Console.WriteLine("Sum is :"+sum);
        }
    }
}
