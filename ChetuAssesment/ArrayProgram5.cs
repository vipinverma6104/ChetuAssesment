using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class ArrayProgram5
    {
        public static void FindDuplicateNum()
        {
            int[] nums=new int[10];
            int[] nums1 = new int[10];
            int index = 0;
            for(int  i=0; i<nums.Length; i++)
            {
                Console.WriteLine("Enter number for {0} index :",i);
                int n=int.Parse(Console.ReadLine());
                nums[i]=n;
            }
            Console.WriteLine("Duplicate numbers in given array :");
            for (int i = 0; i < nums.Length; i++)
            {
                int r = checkExist(nums, nums[i]);
                if(r>1 && checkExist(nums1, nums[i])==0)
                {
                    Console.WriteLine(nums[i]);
                    nums1[index] = nums[i];
                    index++;
                }
            }  
        }

        public static int checkExist(int[] arr,int num)
        {
            int count = 0;
            for(int i=0; i<arr.Length;i++)
            {
                if (arr[i] == num)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
