using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class ArmstrongProgram
    {
        public static void CheckArmstrong()
        {
            int num, sum = 0, rem, temp;
            Console.WriteLine("Enter any number :");
            num=int.Parse(Console.ReadLine());
            temp = num;
            while(num > 0)
            {
                rem = num % 10;
                sum = sum + rem * rem * rem;
                num= num / 10;
            }
            if(temp==sum)
            {
                Console.WriteLine("Number is armstrong !!");
            }
            else
            {
                Console.WriteLine("Number is not armstrong !!");
            }
        }
    }
}
