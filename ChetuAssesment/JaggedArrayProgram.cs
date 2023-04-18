using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChetuAssesment
{
    internal class JaggedArrayProgram
    {
        public static void JaggedArray()
        {
            int[][] nums=new int[3][];
            int[] temp=new int[nums.Length];
            //enter column size for each row
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Please enter column size for {0} row",i);
                int size=int.Parse(Console.ReadLine());
                nums[i]=new int[size];
                temp[i]=size;
            }
            //enter value for array
            for(int i=0; i<3; i++)
            {
                for(int j=0; j < temp[i];  j++)
                {
                    Console.WriteLine("enter value for {0} row,{1} column",i,j);
                    int n= int.Parse(Console.ReadLine());
                    nums[i][j]=n;
                }
            }
            Console.WriteLine("===========================================");
            //enter value for array
            for(int i=0; i<3;i++)
            {
                for(int j= 0; j < temp[i]; j++ )
                {
                    Console.Write(" " + nums[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
