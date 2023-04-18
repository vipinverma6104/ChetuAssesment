using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class ArrayProgram4
    {
        public static void PrintPrimeNum()
        {
            int[] nums = {22,3,44,5,66,89,32,22,7,19};
            Console.WriteLine("Prime Numbers are :");
            foreach (var num in nums)
            {
                if(CheckPrime(num))
                {
                    Console.WriteLine(num);
                }

            }
        }
        public static bool CheckPrime(int num)
        {
            bool flag = true;
            for(int i=2; i<=num/2; i++)
            {
                if(num%i==0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
