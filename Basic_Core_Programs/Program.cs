using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    /// <summary>
    /// Each and every program is in different class 
    /// According to the given menu you can Run that program
    /// </summary>
    class Program
    {
        //Basic Core Programs
        static void Main(string[] args)
        {
            //MENU
            Console.WriteLine("Choose a option from the given List");
            Console.WriteLine("1. Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine("2. Finding Leap Year");
            Console.WriteLine("3. Power Of Two Program");
            Console.WriteLine("\n-------------------------------------------");
            switch (Console.ReadLine())
            {
                case "1":
                    Flip_Coin.FirstProgram();
                    break;
                case "2":
                    LeapYear.SecondProgram();
                    break;
                case "3":
                    PowerOfTwo.ThirdProgram();
                    break;
                default:
                    Console.WriteLine("Please enter valid option");
                    break;
            }
            Console.Read();
        }
    }
}
