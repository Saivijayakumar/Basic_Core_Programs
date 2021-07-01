using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class LargeAmongThree
    {
        public static void NinthProgram()
        {
            int num1, num2, num3;
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("First Number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Third Number :");
            num3 = Convert.ToInt32(Console.ReadLine());
            //num1 = 10 num2 = 12 num3 = 9
            if(num1 >  num2)//10 > 12  fail
            {
                if(num1 > num3)
                {
                    Console.WriteLine("Number One Is Larger");
                }
                else
                {
                    Console.WriteLine("Number Three Is Larger");
                }
            }
            else
            {
                if(num2 > num3)//12 > 9 true
                {
                    Console.WriteLine("Number Two Is Larger");//This is output
                }
                else
                {
                    Console.WriteLine("Number Three Is Larger");
                }
            }

        }
    }
    
}

