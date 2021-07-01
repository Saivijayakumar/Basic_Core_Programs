using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    class PowerOfTwo
    {
        public static void ThirdProgram()
        {
            Console.WriteLine("Enter your choice number");
            int maxPower = Convert.ToInt32(Console.ReadLine());
            //creating a object to access the instance method
            PowerOfTwo obj = new PowerOfTwo();
            obj.PrintTableOfTwo(maxPower);
        }
        private  void PrintTableOfTwo(int power)
        {
            Console.Write("[ ");
            //It print a table of power of two untill our require count
            for(int i=1;i<=power;i++)
            {
                Console.Write(Math.Pow(2, i) + " ");
            }
            Console.WriteLine(" ] ");
        }
    }
}
