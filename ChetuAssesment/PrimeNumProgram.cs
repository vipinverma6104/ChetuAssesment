using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class PrimeNumProgram
    {
        public static void CheckPrime()
        {
            Console.WriteLine("Enter any number :");
            int num=int.Parse(Console.ReadLine());
            if(IsPrime(num))
            {
                Console.WriteLine("Entered number is prime !!");
            }
            else
            {
                Console.WriteLine("Entered number is not a prime !!");
            }

        }
        public static bool IsPrime(int n)
        {
            bool flag = true;
            for(int i=2; i<=n/2; i++)
            {
                if(n%i==0)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
