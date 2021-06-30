using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class Flip_Coin
    {
        public static void FirstProgram()
        {
            Console.WriteLine("Please enter a number to flip a coin");
            //when we read console.readline it consider the input as a string so 
            //we use convert method to change according to user requirement
            int number = Convert.ToInt32(Console.ReadLine());
            ForPercentage(number);
        }
        //Making it as private so that no one can access it outside of  this class.
        private static void ForPercentage(int number)
        {
            int head = 0, tail = 0;
            //creating object for random class
            Random random = new Random();
            for(int i=0; i < number;i++)
            {
                //geting a random value.Here it gives in the range from 0 to 1
                double value = random.NextDouble();
                if(value < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
            Console.WriteLine("Number of Heads " + head + " out of " + number);
            Console.WriteLine("Number of Tails " + tail + " out of " + number);
            double Headpercentage = (double)head / number * 100;
            double Tailpercentage = (double)tail / number * 100;
            Console.WriteLine("Tail Percentage " + Tailpercentage);
            Console.WriteLine("Head Percentage " + Headpercentage);
        }
    }
}
