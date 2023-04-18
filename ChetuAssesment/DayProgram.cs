using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class DayProgram
    {
        public static void PrintDay()
        {
            Console.WriteLine("Enter a number between 0 and 6 :");
            int n=int.Parse(Console.ReadLine());
                switch(n)
                {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Not a day");
                        break;
            }
        }
    }
}
