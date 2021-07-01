using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class PrimeFactor
    {
        public static void TenthProgram()
        {
            Console.WriteLine("Enter Number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            FindPrimeFactors(number);
        }
        // This function help to print all prime factors of a given number n
        public static void FindPrimeFactors(int n)
        {
            Console.Write("The Prime Factors for {0} is : ", n);
            //It will Print number of 2s that divide by n
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }
            //when we reach to this position n must be odd.For that we can skip one element
            for (int i = 3; i <= Math.Sqrt(n); i += 2)//here i is increment with i = i+2;
            {
                // While i divides n, print i and divide n
                while (n % i == 0)
                {
                    Console.Write(i + " ");
                    n /= i;
                }
            }
            if (n > 2)
                Console.Write(n);
        }

    }
}