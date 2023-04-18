using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class ArrayProgram8
    {
        public static void SearchSpecificNum()
        {
            int[] nums = { 45, 16, 18, 32, 65, 48, 98, 78, 66, 99 };
            Console.WriteLine("Enter a number to search :");
            int n=int.Parse(Console.ReadLine());
            int flag = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == n)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag == 1)
            {
                Console.WriteLine("Searched number is found ");
            }
            else
            {
                Console.WriteLine("Searched number is not found ");
            }
        }
    }
}
