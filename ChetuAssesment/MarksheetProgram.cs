using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class MarksheetProgram
    {
        public static void PrintMarkSheet()
        {
            Console.WriteLine("Enter Mathematics marks :");
            double math = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Physics marks :");
            double physics = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Chemistry marks :");
            double chemistry = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter English marks :");
            double eng = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hindi marks :");
            double hindi = double.Parse(Console.ReadLine());
            Console.WriteLine("Total marks, Percentage and Grade is :");
            double total_marks=math+physics+chemistry+eng+hindi;
            double per = total_marks / 5;
            string grade;
            if(per>=75 && per<100)
            {
                grade = "A++";
            }
            else if(per>=60 && per<75)
            {
                grade = "A+";
            }
            else if(per>=50 && per<60)
            {
                grade = "B";
            }
            else if(per>=33 && per<50)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("{0} {1} {2}",total_marks,per,grade);
        }
    }
}
