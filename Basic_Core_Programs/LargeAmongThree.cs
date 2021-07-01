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
            //By using the Ternary Operator concept we are doing this logic
            //Here num1 = 10 num2 = 12 num3 = 9
            string output = num1 > num2 && num1 >num3 ? "Number One Is Larger":num2 > num3 ? "Number Two Is Larger": "Number Three Is Larger";
            Console.WriteLine(output);
        }
    }
    
}

