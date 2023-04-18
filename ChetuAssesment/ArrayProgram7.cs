using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class ArrayProgram7
    {
        public static void FindIntersection()
        {
            int[] num1 =new int[10] { 10, 12, 15, 16, 18, 26, 30, 29, 21, 45};
            int[] num2 =new int[10] { 10, 45, 10, 78, 36, 15, 16, 10, 15, 21 };
            int[] num3 = new int[10];
            int index = 0;
            Console.WriteLine("Intersect elements in both array is :");
            for (int i = 0; i < num1.Length; i++)
            {
                int n = num1[i];
                for(int j = 0; j < num2.Length; j++)
                {
                    if (n == num2[j])
                    {
                        num3[index] = n;
                        index++;
                        break;
                    }
                }
            }
            for(int k = 0;  k < num3.Length; k++)
            {
                Console.WriteLine(num3[k]);
            }
        }
    }
}
