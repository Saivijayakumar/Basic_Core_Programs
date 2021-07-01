using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class swaping
    {
        public static void sixthProgram()
        {
            Console.WriteLine("Enter first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int second = Convert.ToInt32(Console.ReadLine());
            SwapingWithoutTemp(first, second);
        }
        //here a = 50  b = 60
        private static void SwapingWithoutTemp(int a,int b)
        {
            //here we use * and  / operators
            Console.WriteLine("Before Swaping  a = {0}  b = {1}", a, b);
            a = a * b;//a = 3000 (50*60)
            b = a / b;//b = 50 (3000/60)
            a = a / b;//a = 60 (3000/50)
            Console.WriteLine("After Swaping without Temp a = {0}  b = {1}", a, b);
        }
    }
}
