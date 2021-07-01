using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class HarmonicProgram
    {
        public static void FourthProgram()
        {
            Console.WriteLine("Enter nth harmonic number");
            int number = Convert.ToInt32(Console.ReadLine());
            HarmonicProgram harmonicProgram = new HarmonicProgram();
            harmonicProgram.FindNthHarmonicNumber(number);
        }
        private void FindNthHarmonicNumber(int number)
        {
            double sum = 0;
            for(int i=1;i<=number;i++)
            {
                sum += (double)1 / i;
            }
            Console.WriteLine(number + "th harmonic value =" + sum);
        }
        
    }
}
