using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class LeapYear
    {
        public static void SecondProgram()
        {
            int Year;
            Console.WriteLine("Please enter a Year :");
            Year = Convert.ToInt32(Console.ReadLine());
            if(Year >= 1000 && Year <= 9999)
            {
                if(((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
                {
                    Console.WriteLine("{0} is a Leap Year",Year);
                }
                else
                {
                    Console.WriteLine("{0} is Not a Leap Year",Year);
                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid year!!!");
            }
        }
    }
}
