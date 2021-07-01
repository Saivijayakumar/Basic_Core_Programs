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
            //It check the given Year is valid or not like It is a four digit number or not
            if(Year >= 1000 && Year <= 9999)
            {
                //If this condition (Year % 400 == 0) satisfy it is definatly a leap year but in 
                //some cases the aboue condition will fail even though it is leap year then we have to use
                //this condition (Year % 4 == 0) && (Year % 100 != 0) if it pass then it is also a leapYear
                if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
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
