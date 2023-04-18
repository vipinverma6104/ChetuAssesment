using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class AmountDisProgram
    {
        public static void CalculateDiscountAmt()
        {
            Console.WriteLine("Enter purchase amount :");
            double puramt=double.Parse(Console.ReadLine());
            Console.WriteLine("Amount after discount is :");
            if (puramt >= 5000 )
            {
                puramt = puramt - (puramt * 20 / 100);
            }
            else if(puramt>=2000 &&  puramt<5000)
            {
                puramt=puramt- (puramt * 15 /100);
            }
            else if(puramt>=1000 && puramt<2000)
            {
                puramt=puramt-(puramt * 10 /100);
            }
            else
            {
                puramt=puramt-(puramt*5/100);
            }
            Console.WriteLine(puramt);
        }
    }
}
