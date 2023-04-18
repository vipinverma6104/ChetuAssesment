using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class ArmstrongProgram2
    {
        public static void FindAllArmstrongNum()
        {
            Console.WriteLine("Enter first number :");
            int n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number :");
            int n2=int.Parse(Console.ReadLine());
            Console.WriteLine($"Armstrong number between {n1} and {n2} is :");
            for (int i=n1; i<=n2; i++)
            {
                int check, rem, sum = 0;
                check = i;
                while(check > 0)
                {
                    rem = check % 10;
                    sum = sum + (rem * rem * rem);
                    check = check / 10;
                }
                if(sum==i)
                {
                    Console.WriteLine(i);
                }
                
            }

        }
    }
}
