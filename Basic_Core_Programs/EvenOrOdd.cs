using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class EvenOrOdd
    {
        public static void seventh()
        {
            Console.WriteLine("Enter number ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number & 1)
            {
                Console.WriteLine("{0} is a Odd Number", number);
            }
            else
            {
                Console.WriteLine("{0} is a Even Number", number);
            }
            /*//Logic for finding given number is even or odd 
            if(number % 2 == 0)
            {
                Console.WriteLine("{0} is a Even Number", number);
            }
            else
            {
                Console.WriteLine("{0} is a Odd Number", number);
            }*/
        }
    }
}
