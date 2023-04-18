using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class ArrayProgram2
    {
        public static void NumSortingInArray()
        {
            int[] nums= new int[10];
            for(int i=0; i<nums.Length; i++)
            {
                Console.WriteLine("Enter number for {0} index",i);
                int n= int.Parse(Console.ReadLine());
                nums[i]= n;
            }

            for(int i=0; i<nums.Length;i++)
            {
                for(int j=i+1; j<nums.Length;j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp = nums[i];
                        nums[i]= nums[j];
                        nums[j]= temp;
                    }
                }
            }
            Console.WriteLine("Sorting numbers in Ascending order: ");

            for (int i=0; i<nums.Length;i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
