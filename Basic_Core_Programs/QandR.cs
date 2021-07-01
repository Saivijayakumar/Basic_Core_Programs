using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    //here dividend = 23 divisor = 10
    class QandR
    {
        public static void fifth()
        {
            Console.WriteLine("Enter dividend value");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor value");
            int divisor = Convert.ToInt32(Console.ReadLine());
            //For quotient we use /
            int quotient = dividend / divisor;
            //For remainder we use %
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient for {0} is {1}", dividend, quotient);
            Console.WriteLine("Remainder for {0} is {1}", dividend, remainder);
        }
    }
}
